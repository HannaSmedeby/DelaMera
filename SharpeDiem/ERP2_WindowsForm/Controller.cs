using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP2_WindowsForm
{
    public class Controller
    {
        WebServiceClient.ERP2_WebServiceSoapClient client; 

        public Controller()
        {
           client = new WebServiceClient.ERP2_WebServiceSoapClient();
        }

        //Data methods

        public DataTable EmployeeContents(string args)
        {
            return Utils.ConvertListToDataTable(client.EmployeeContents(args));
        }
        public DataTable EmployeeRelatives()
        {
            return Utils.ConvertListToDataTable(client.EmployeeRelatives());
        }

        public DataTable SickEmployees()
        {
            return Utils.ConvertListToDataTable(client.SickEmployees());
        }

        public DataTable MostSickEmployee()
        {
            return Utils.ConvertListToDataTable(client.MostSickEmployee());
        }

        //Metadata methods
        public DataTable GetAllKeys(string args)
        {
            return Utils.ConvertListToDataTable(client.GetAllKeys(args));                
        }

        public DataTable AllIndexes(string args)
        {
            return Utils.ConvertListToDataTable(client.AllIndexes(args));
        }

        public DataTable AllConstraints(string args)
        {
            return Utils.ConvertListToDataTable(client.AllConstraints(args));
        }

        public DataTable AllTableNames1()
        {
            return Utils.ConvertListToDataTable(client.AllTableNames1());
        }

        public DataTable AllTableNames2()
        {
            return Utils.ConvertListToDataTable(client.AllTableNames2());
        }

        public DataTable AllEmployeeColumnNames1()
        {
            return Utils.ConvertListToDataTable(client.AllEmployeeColumns1());
        }

        public DataTable AllEmployeeColumns2()
        {
            return Utils.ConvertListToDataTable(client.AllEmployeeColumns2());
        }

        public object[] EmployeeTablesTableNames()
        {
            object[] tableNames = new object[7];
            List<string> stringTableNames = client.EmployeeTablesTableNames();
            int i = 0;
            foreach (string table in stringTableNames)
            {
                tableNames[i] = table;
                i++;
            }
            return tableNames;
        }

        
    }
}
