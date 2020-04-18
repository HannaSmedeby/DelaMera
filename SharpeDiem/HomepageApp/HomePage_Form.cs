using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomepageApp
{
    public partial class HomePage_Form : Form
    {
        public HomePage_Form()
        {
            InitializeComponent();
        }

        private void pk_1_Btn_Click(object sender, EventArgs e)
        {
           
            SharpeDiem.ItemApp f = new SharpeDiem.ItemApp();
            f.ShowDialog();
           
        }

        private void pk_2_Btn_Click(object sender, EventArgs e)
        {

            Uppgift2.MainWindow f = new Uppgift2.MainWindow();
            f.ShowDialog(); 
            
        }

        private void ws_1_Btn_Click(object sender, EventArgs e)
        {
            EventHandlerA1.WebService1_Form f = new EventHandlerA1.WebService1_Form();
            f.ShowDialog();
        }

        private void ws_2_Btn_Click(object sender, EventArgs e)
        {
            
            EventHandlerWebA2.WebService2_Form f = new EventHandlerWebA2.WebService2_Form();
            f.ShowDialog();
        }

        private void erp_1_Btn_Click(object sender, EventArgs e)
        {
            ERP1_WindowsForm.ERP1_Form f = new ERP1_WindowsForm.ERP1_Form();
            f.ShowDialog();

        }

        private void erp_2_Btn_Click(object sender, EventArgs e)
        {

            ERP2_WindowsForm.ERP2_Form f = new ERP2_WindowsForm.ERP2_Form();
            f.ShowDialog(); 

        }

        private void btnConsole_Click(object sender, EventArgs e)
        {
            try
            {
            Process.Start(@"C:\Users\Administrator\source\repos\vt19-sysa14-programkonstruktion-pa1-vt19-sysa14-ediem3\SharpeDiem\ConsoleApp\bin\Debug\ConsoleApp.exe"); 
            }
            catch (Exception e1)
            {
              
            }
        }

        
    }
}
