using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventHandlerWebA2.localhost;

namespace EventHandlerWebA2
{
    public partial class WebService2_Form : Form
    {
        ServiceReference.WebServiceSoapClient service = new ServiceReference.WebServiceSoapClient();
       

        public WebService2_Form()
        {
            InitializeComponent();
        }

        private void buttonGetItem_Click(object sender, EventArgs e)
        {
          
            dataGridView1.DataSource = service.GetItem();
        }

        private void buttonGetLoan_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = service.GetLoan();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
