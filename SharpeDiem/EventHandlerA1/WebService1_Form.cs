using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventHandlerA1.localhost;


namespace EventHandlerA1
{
    public partial class WebService1_Form : Form
    {
        ServiceReference.WebServiceSoapClient service = new ServiceReference.WebServiceSoapClient();
      
        string str = "";
        string str1;

        public WebService1_Form()
        {
            InitializeComponent();
        }

        private void getDocumentBtn_Click(object sender, EventArgs e)
        {
            if (textBoxDocument.Text == "")
            {
                labelOutputText.Text = "Please fill out a document name.";
            }
            else
            {
                str = textBoxDocument.Text;
                str1 = service.GetFile(str);
                labelOutputText.Text = str1;
            }

        }

        
    }
}
