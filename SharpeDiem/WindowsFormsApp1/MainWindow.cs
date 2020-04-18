using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift2
{
    public partial class MainWindow : Form

    {
        Controller controller = new Controller();


        public MainWindow()
        {
            InitializeComponent();
            tablesBox.Items.AddRange(controller.getTablesOfInterest());

        }


        private void ColumnNamesBtn_Click(object sender, EventArgs e)
        {
            
                table.Rows.Clear();
                table.Columns.Clear();
                table.Columns.Add("Column names");

           

            try
            {
                String temp = tablesBox.SelectedItem.ToString();
                foreach (string s in controller.getColumnNames(temp))
                {
                    var row = table.NewRow();
                    row["Column names"] = s;
                    table.Rows.Add(row);
                    
                }
                dataGridView.DataSource = table;
            }
            catch
            {
                responseLbl.Text = "Please choose a table";
            }
   
        }

        private void NbrOfRowsBtn_Click(object sender, EventArgs e)
        {
            try
            {
            String temp = tablesBox.SelectedItem.ToString();

            table.Columns.Clear();
            table.Rows.Clear();

            table.Columns.Add("Number of rows");

            int i = controller.getTableRows(tablesBox.Text);
            var row = table.NewRow();
            row["Number of ROws"] = i.ToString();
            table.Rows.Add(row);

            dataGridView.DataSource = table;
            }
            catch
            {
                responseLbl.Text = "Please choose a table";
            }
        }
    }
}