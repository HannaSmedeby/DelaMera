using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ERP1_WindowsForm
{
    class Controller
    {
        WebApplication1.WebService1 ws = new WebApplication1.WebService1();
        WebServiceClientERP1.WebService1SoapClient soap;
        Utils utils = new Utils();

        public Controller()
        {
            soap = new WebServiceClientERP1.WebService1SoapClient();
        }

        public bool Create(string initials, string name, string lastName, string title, string address, string phoneNumber)
        {
            return soap.Create(initials, name, lastName, title, address, phoneNumber);
        }

        public bool Update(string id, string name, string lastName, string title, string address, string phoneNumber)
        {
            return soap.Update(id, name, lastName, title, address, phoneNumber);
        }

        public bool Delete(string id)
        {
            //Temp list holdning employee
            List<string> list = soap.Find(id);

            try
            {
                //Tries to get string from list to check if employee excist in database. 
                String temp = list[1];
                return soap.Delete(id);
            } catch
            {
                return false;
            }
            

            
            /*
            if(String.IsNullOrEmpty(temp).Equals(false))
            {
                return soap.Delete(id);
            } else
            {
                return false;
            } */
        }

        public DataTable Read()
        {
            List<List<String>> list = ws.Read();
            return utils.ConvertListToDataTable(list);
        }
        public List<string> Find(string id)
        {
            List<string> list = soap.Find(id);
            return list;
        }

    }
}
