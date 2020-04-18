using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpeDiem
{
    public partial class LoanApp : Form
    {
        Controller controller;
        ViewHandler viewHandler;
        ExceptionHandler exceptionHandler;
        string message;
        List<string> valueChanged;

        private string IdFromCell { get; set; }


        public LoanApp()
        {
            InitializeComponent();
            controller = new Controller();
            viewHandler = new ViewHandler();
            exceptionHandler = new ExceptionHandler();
            valueChanged = new List<string>();
        }

        private void itemBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            ItemApp itemApp = new ItemApp();
            itemApp.ShowDialog();
        }

        private void create_Click(object sender, EventArgs e)
        {
            createErrorMessageLbl.Text = "";
            string[] parameters = new string[3];
            if (Convert.ToDateTime(borrowDateTimePicker.Text) < Convert.ToDateTime(returnDateTimePicker.Text))
            {
                try
                {
                    parameters[0] = borrowDateTimePicker.Text;
                    parameters[1] = returnDateTimePicker.Text;
                    parameters[2] = IdFromCell;

                    bool b = controller.CreateLoan(parameters);
                    Console.WriteLine(b);
                    if (b.Equals(true))
                    {
                        createErrorMessageLbl.ForeColor = System.Drawing.Color.Green;
                        createErrorMessageLbl.Text = "Loan successfully added!";
                        showAllAvailableItems_Click(new object(), new EventArgs());
                        IdFromCell = null;
                    }
                }
                catch (SqlException sE)
                {
                    message = exceptionHandler.ExceptionMessage(sE);
                    createErrorMessageLbl.ForeColor = System.Drawing.Color.Red; 
                    createErrorMessageLbl.Text = message;
                }
                catch (Exception eX)
                {
                    message = exceptionHandler.ExceptionMessage(eX);
                    createErrorMessageLbl.ForeColor = System.Drawing.Color.Red;
                    createErrorMessageLbl.Text = message;
                }
            } 
            else
            {
                createErrorMessageLbl.ForeColor = System.Drawing.Color.Red;
                createErrorMessageLbl.Text = "Invalid dates, return date is before borrow date. Choose again.";
            }
        }

        private void findBtn_Click(object sender, EventArgs e) 
        {
            errorMessageLbl.Text = "";
            // If user has entered a loan number as search parameter, display loan
            if (findTextBox.Text.Length > 0)
            {
                string loanNbr = findTextBox.Text;
                try
                {
                    dataGridViewLoans.DataSource = controller.DisplayLoans(" WHERE loanNumber = '" + loanNbr + "'");
                }
                catch (SqlException sE)
                {
                    message = exceptionHandler.ExceptionMessage(sE);
                    errorMessageLbl.ForeColor = System.Drawing.Color.Red;
                    errorMessageLbl.Text = message;
                }
                catch (Exception eX)
                {
                    message = exceptionHandler.ExceptionMessage(eX);
                    errorMessageLbl.ForeColor = System.Drawing.Color.Red;
                    errorMessageLbl.Text = message;
                }
            }
            // If user has entered an item number as search parameter, display all loans containing item
            else if(findItemNumberTextBox.Text.Length > 0)
            {
                string itemNbr = findItemNumberTextBox.Text;
                try
                {
                    dataGridViewLoans.DataSource = controller.DisplayLoans(" WHERE itemNumber = '" + itemNbr + "'");
                }
                catch (SqlException sE)
                {
                    message = exceptionHandler.ExceptionMessage(sE);
                    errorMessageLbl.ForeColor = System.Drawing.Color.Red;
                    errorMessageLbl.Text = message;
                }
                catch (Exception eX)
                {
                    message = exceptionHandler.ExceptionMessage(eX);
                    errorMessageLbl.ForeColor = System.Drawing.Color.Red;
                    errorMessageLbl.Text = message;
                }
            }
            // If user has entered a timespan as search parameter, display all loans who has that timespan
            // Check if the value has been changed in the datetimepickers
            else if (valueChanged.Contains("borrowDateTimePicker") || valueChanged.Contains("returnDateTimePicker"))
            {
                string borrowDate = searchBorrowDateTimePicker.Text;
                string returnDate = searchReturnDateTimePicker.Text;
                try
                {
                    dataGridViewLoans.DataSource = controller.DisplayLoans(" WHERE borrowDate = '" + borrowDate + "' AND returnDate = '" + returnDate + "'");
                }
                catch (SqlException sE)
                {
                    message = exceptionHandler.ExceptionMessage(sE);
                    errorMessageLbl.ForeColor = System.Drawing.Color.Red;
                    errorMessageLbl.Text = message;
                }
                catch (Exception eX)
                {
                    message = exceptionHandler.ExceptionMessage(eX);
                    errorMessageLbl.ForeColor = System.Drawing.Color.Red;
                    errorMessageLbl.Text = message;
                }
            }
            // If no search parameters are entered, display error message
            else
            {
                errorMessageLbl.ForeColor = System.Drawing.Color.Red;
                errorMessageLbl.Text = "Fill in search arguments";
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            errorMessageLbl.Text = "";
            string id = IdFromCell;
            var form = new GUI.UpdateLoan(id);

            if (id != null)
            {
                form.Show(this);
                IdFromCell = null;
            }
            else
            {
                errorMessageLbl.ForeColor = System.Drawing.Color.Red;
                errorMessageLbl.Text = "Please double click on the loan you want to update";
            }

        
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            errorMessageLbl.Text = "";
            try
            { 
                controller.RemoveLoan(this.IdFromCell);
                dataGridViewLoans.DataSource = controller.DisplayLoans(null);
                errorMessageLbl.ForeColor = System.Drawing.Color.Green;
                errorMessageLbl.Text = IdFromCell + " has been removed!";
                IdFromCell = null;
            }
            catch (SqlException sE)
            {
                message = exceptionHandler.ExceptionMessage(sE);
                errorMessageLbl.ForeColor = System.Drawing.Color.Red;
                errorMessageLbl.Text = message;

            }
            catch (Exception eX)
            {
                message = exceptionHandler.ExceptionMessage(eX);
                errorMessageLbl.ForeColor = System.Drawing.Color.Red;
                errorMessageLbl.Text = message;
            }
            
        }

        private void showAllLoans_Click(object sender, EventArgs e)
        {
            dataGridViewLoans.DataSource = controller.DisplayLoans(null);
        }

        private void searchBorrowDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            valueChanged.Add("borrowDateTimePicker");
        }

        private void searchReturnDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            valueChanged.Add("returnDateTimePicker");
        }

        private void cellClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridView gridView = sender as DataGridView;
            IdFromCell = gridView[0, e.RowIndex].Value.ToString();

        }

        private void showAllAvailableItems_Click(object sender, EventArgs e)
        {
            DateTime borrowDate = Convert.ToDateTime(borrowDateTimePicker.Text);
            DateTime returnDate = Convert.ToDateTime(returnDateTimePicker.Text);
            if (borrowDate < returnDate)
            {
                string args = controller.GetAvailableItems(borrowDate, returnDate);
                dataGridViewAvailableItems.DataSource = controller.DisplayItems(args);
            }
            else
            {
                createErrorMessageLbl.ForeColor = System.Drawing.Color.Green;
                createErrorMessageLbl.Text = "Invalid dates, return date is before borrow date. Choose again.";
            }

        }

    }
}
