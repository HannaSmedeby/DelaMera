using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpeDiem.GUI
{
    public partial class UpdateLoan : Form
    {
        string loanId;
        Controller controller;
        ExceptionHandler exceptionHandler;
        ViewHandler viewHandler;
        string itemId;
        public UpdateLoan(string loanId)
        {
            InitializeComponent();
            this.loanId = loanId;
            controller = new Controller();
            exceptionHandler = new ExceptionHandler();
            viewHandler = new ViewHandler();
            loanNbrLbl.Text = "Update loan nbr: " + loanId;
            updateErrorMessageLbl.Text = "Window will be closed automatically when update is complete";
        }

        private void ShowAllAvailableItems_Click(object sender, EventArgs e)
        {
            DateTime borrowDate = Convert.ToDateTime(updateBorrowDateTimePicker.Text);
            DateTime returnDate = Convert.ToDateTime(updateReturnDateTimePicker.Text);
            string args = controller.GetAvailableItems(borrowDate, returnDate);

            dataGridViewUpdate.DataSource = controller.DisplayItems(args);
        }

        private void CompleteUpdateBtn_Click(object sender, EventArgs e)
        {

            string[] parameters = new string[3];
            parameters[0] = updateBorrowDateTimePicker.Text;
            parameters[1] = updateReturnDateTimePicker.Text;
            parameters[2] = itemId;
            try
            {
                controller.UpdateLoan(loanId, parameters);
                this.Dispose();
            }
            catch (SqlException sE)
            {
                string message = exceptionHandler.ExceptionMessage(sE);
                updateErrorMessageLbl.ForeColor = System.Drawing.Color.Red; 
                updateErrorMessageLbl.Text = message;
            }
            catch (Exception eX)
            {
                string message = exceptionHandler.ExceptionMessage(eX);
                updateErrorMessageLbl.Text = message;
            }
        }

        private void cellClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            itemId = gridView[0, e.RowIndex].Value.ToString();
        }

    }
}
