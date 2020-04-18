using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP2_WindowsForm
{
    public partial class ERP2_Form : Form
    {
        Controller controller;

        public ERP2_Form()
        {
            InitializeComponent();
            controller = new Controller();
            empTablesSelection.Items.AddRange(controller.EmployeeTablesTableNames());
        }

        private void metaDataBtn_Click(object sender, EventArgs e)
        {
            string query = metaDataSelections.Text;
            switch (metaDataSelections.Text) {
                case "All keys":
                    metaDataTable.DataSource = controller.GetAllKeys(null);
                    return;
                case "All indexes":
                    metaDataTable.DataSource = controller.AllIndexes(null);
                    return;
                case "All constraints":
                    metaDataTable.DataSource = controller.AllConstraints(null);
                    return;
                case "All table names 1":
                    metaDataTable.DataSource = controller.AllTableNames1();
                    return;
                case "All table names 2":
                    metaDataTable.DataSource = controller.AllTableNames2();
                    return;
                case "All employee columns 1":
                    metaDataTable.DataSource = controller.AllEmployeeColumnNames1();
                    return;
                case "All employee columns 2":
                    metaDataTable.DataSource = controller.AllEmployeeColumns2();
                    return;
            }
        }

        private void getDataBtn_Click(object sender, EventArgs e)
        {
            switch (getDataSelections.Text)
            {
                case "Employees and their relatives":
                    empContentView.DataSource = controller.EmployeeRelatives();
                    return;
                case "Sick employees 2004":
                    empContentView.DataSource = controller.SickEmployees();
                    return;
                case "Most sick employee":
                    empContentView.DataSource = controller.MostSickEmployee();
                    return;
            }
        }

        private void getEmpMetaBtn_Click(object sender, EventArgs e)
        {
            foreach(string s in controller.EmployeeTablesTableNames())
            {
                if (empTablesSelection.Text.Equals(s))
                {
                    empContentView.DataSource = controller.EmployeeContents(s);

                    switch (getEmpMetaSelections.Text)
                    {                      
                        case "All keys":
                            empMetaView.DataSource = controller.GetAllKeys(s);
                            return;
                        case "All indexes":
                            empMetaView.DataSource = controller.AllIndexes(s);
                            return;
                        case "All constraints":
                            empMetaView.DataSource = controller.AllConstraints(s);
                            return;
                    }
                }
            }
        }
    }
}
