using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Uppgift2
{
    public class DatabaseConnection
    {
        public static string connectionString = "server=uwdb18.srv.lu.se\\icssql001; database=SYSA14_PK_ProgAssignment2; User ID = sysa14reader; Password=INFreader1";
        public SqlConnection myConnection = new SqlConnection(connectionString);
        SqlCommand myCommand = new SqlCommand();
        StringBuilder errorMessages = new StringBuilder();



        public void OpenConnection()
        {
            try
            {
                myConnection.Open();
                Console.WriteLine("MySQL version : {0}", myConnection.ServerVersion);
            }
            catch (SqlException sE)
            {
                for (int i = 0; i < sE.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                    "Message: " + sE.Errors[i].Message + "\n" +
                    "LineNumber: " + sE.Errors[i].LineNumber + "\n" +
                    "Source: " + sE.Errors[i].Source + "\n" +
                    "Procedure: " + sE.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
            catch (Exception ex)
            {
                errorMessages.Append(ex.Message);
                Console.WriteLine(errorMessages.ToString());
            }
        }

        public void CloseConnection()
        {
            myConnection.Close();
        }
    }
}
