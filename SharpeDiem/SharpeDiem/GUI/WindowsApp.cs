using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpeDiem
{
    public partial class WindowsApp : Form
    {
        ItemApp itemApp = new ItemApp();
        LoanApp loanApp = new LoanApp();

        public WindowsApp()
        {
            InitializeComponent();
        }
    

        private void itemBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            itemApp.ShowDialog();
        }

        private void loanBtn_Click(object sender, EventArgs e)
        {
            
            this.Hide(); 
            loanApp.ShowDialog();
            
        }
    }
}
