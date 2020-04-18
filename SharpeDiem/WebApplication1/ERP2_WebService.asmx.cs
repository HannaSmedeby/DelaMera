using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for ERP2_WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ERP2_WebService : System.Web.Services.WebService
    {
        WebApplication1.DAL.ERP2_DAL dal = new WebApplication1.DAL.ERP2_DAL();

        //DATA METHOODS

        //Gets the contents of employee tables
        [WebMethod]
        public List<List<string>> EmployeeContents(string args)
        {
            return dal.EmployeeContents(args);
        }

        //Information about employees and their relatives
        [WebMethod]
        public List<List<string>> EmployeeRelatives()
        {
            return dal.EmployeesRelatives();
        }

        //Employees abscent due to sickness in 2004
        [WebMethod]
        public List<List<string>> SickEmployees()
        {
            return dal.SickEmployees();
        }

        //Employee who has been abscent the most
        [WebMethod]
        public List<List<string>> MostSickEmployee()
        {
            return dal.MostSickEmployee();
        }

        //METADATA METHODS

        //All keys - for entire database or table of user's choice
        [WebMethod]
        public List<List<string>> GetAllKeys(string args)
        {
            return dal.GetAllKeys(args);
        }

        //All indexes - for entire database or table of user's choice
        [WebMethod]
        public List<List<string>> AllIndexes(string args)
        {
            return dal.AllIndexes(args);
        }

        //All constraints - for entire database or table of user's choice
        [WebMethod]
        public List<List<string>> AllConstraints(string args)
        {
            return dal.AllConstraints(args);
        }

        //All tables in the database, two solutions required
        [WebMethod]
        public List<List<string>> AllTableNames1()
        {
            return dal.AllTableNames1();
        }

        //All tables in the database, two solutions required
        [WebMethod]
        public List<List<string>> AllTableNames2()
        {
            return dal.AllTableNames2();
        }

        //All columns in the employee table, two solutions required
        [WebMethod]
        public List<List<string>> AllEmployeeColumns1()
        {
            return dal.AllEmployeeColumns1();
        }

        //All columns in the employee table, two solutions required
        [WebMethod]
        public List<List<string>> AllEmployeeColumns2()
        {
            return dal.AllEmployeeColumns2();
        }

        //Names of all employee-tables
        [WebMethod]
        public List<string> EmployeeTablesTableNames()
        {
            return dal.EmployeeTables();
        }
    }
}
