using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ERP1_WindowsForm
{
    public partial class ERP1_Form : Form
    {
        WebApplication1.DAL.ERP1_DAL dal = new WebApplication1.DAL.ERP1_DAL();
        ERP2_WindowsForm.Utils u = new ERP2_WindowsForm.Utils();
        WebApplication1.WebService1 wS = new WebApplication1.WebService1();
        ERP1_WindowsForm.Controller con = new ERP1_WindowsForm.Controller();


        //ServiceReference1.WebService1SoapClient soap = new ServiceReference1.WebService1SoapClient();
        WebServiceClientERP1.WebService1SoapClient soap = new WebServiceClientERP1.WebService1SoapClient();

        public ERP1_Form()
        {
            InitializeComponent();
        }

        //
        // Show all button
        //
        private void showAllBtn_Click(object sender, EventArgs e)
        {
            findRemoveResponseLbl.ResetText();
            createResponseLbl.ResetText();

            DataTable dT = con.Read();
            showAllGridView.DataSource = dT;

        }

        //
        // Create Button
        //
        private void createBtn_Click(object sender, EventArgs e)
        {
            findRemoveResponseLbl.ResetText();
            createResponseLbl.ResetText();

            string id = idTextBox.Text;
            string name = nameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string title = jobTitleTextBox.Text;
            string address = addressTextBox.Text;
            string phoneNbr = phoneNbrTextBox.Text;
            if (string.IsNullOrEmpty(id).Equals(true) || string.IsNullOrEmpty(name).Equals(true) || string.IsNullOrEmpty(lastName).Equals(true) 
                || string.IsNullOrEmpty(title).Equals(true) || string.IsNullOrEmpty(address).Equals(true) || string.IsNullOrEmpty(phoneNbr).Equals(true))
            {
                createResponseLbl.Text = "Please fill in all information";

            }
            else
            {
                bool b = con.Create(id, name, lastName, title, address, phoneNbr);

                if (b.Equals(true))
                {
                    createResponseLbl.Text = "Employee " + id + " was added to the database";

                    idTextBox.ResetText();
                    nameTextBox.ResetText();
                    lastNameTextBox.ResetText();
                    jobTitleTextBox.ResetText();
                    addressTextBox.ResetText();
                    phoneNbrTextBox.ResetText();
                }
                else
                {
                    createResponseLbl.Text = "Employee could not be created.";
                }
            }

        }

        //
        //Update button
        //
        private void updateBtn_Click(object sender, EventArgs e)
        {
            findRemoveResponseLbl.ResetText();
            createResponseLbl.ResetText();

            string id = idTextBox.Text;
            string name = nameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string title = jobTitleTextBox.Text;
            string address = addressTextBox.Text;
            string phoneNbr = phoneNbrTextBox.Text;

            if (string.IsNullOrEmpty(id).Equals(true) || string.IsNullOrEmpty(name).Equals(true) || string.IsNullOrEmpty(lastName).Equals(true)
                || string.IsNullOrEmpty(title).Equals(true) || string.IsNullOrEmpty(address).Equals(true) || string.IsNullOrEmpty(phoneNbr).Equals(true))
            {
                createResponseLbl.Text = "Please search for an employee";

            } else
            {
                bool b = con.Update(id, name, lastName, title, address, phoneNbr);

                if (b.Equals(true))
                {
                    createResponseLbl.Text = "Employee " + id + " was updated";

                    idTextBox.ResetText();
                    nameTextBox.ResetText();
                    lastNameTextBox.ResetText();
                    jobTitleTextBox.ResetText();
                    addressTextBox.ResetText();
                    phoneNbrTextBox.ResetText();

                }
                else
                {
                    createResponseLbl.Text = "Employee could not be updated. ";
                }
            }
        }
        //
        //Delete button
        //
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            findRemoveResponseLbl.ResetText();
            createResponseLbl.ResetText();

            string id = removeFindIdTextBox.Text;

            if(string.IsNullOrEmpty(id).Equals(true))
            {
                findRemoveResponseLbl.Text = "Please fill in all information";

            } else
            {
                bool b = false;
                b = con.Delete(id);

                if (b.Equals(true))
                {

                    findRemoveResponseLbl.Text = id + " was removed from the database.";
                    removeFindIdTextBox.ResetText();
                }
                else
                {
                    findRemoveResponseLbl.Text = "Employee could not be removed";
                    removeFindIdTextBox.ResetText();
                }
            }

        }
        //
        //Find button
        //
        private void findBtn_Click(object sender, EventArgs e)
        {
            String id = idTextBox.Text;

            if(String.IsNullOrEmpty(id).Equals(false))
            {
                List<string> list = con.Find(id);

                try
                {
                    nameTextBox.Text = list[1].ToString();
                    lastNameTextBox.Text = list[2].ToString();
                    jobTitleTextBox.Text = list[3].ToString();
                    addressTextBox.Text = list[4].ToString();
                    phoneNbrTextBox.Text = list[5].ToString();
                }
                catch
                {
                    createResponseLbl.Text = "Employee does not excist in database";
                }
            } else
            {
                createResponseLbl.Text = "Please enter id number";
            }
        }
    }
}
