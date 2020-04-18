using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication.DatabaseHandler
{
    public class DatabaseConnection
    {
        static string connectionString = "server=SYST4DEV01; Trusted_Connection=true; database=Demo Database NAV (5-0);";
        public SqlConnection myConnection = new SqlConnection(connectionString);
        SqlCommand myCommand = new SqlCommand();
        StringBuilder errorMessages = new StringBuilder();

        public bool OpenConnection()
        {
            bool open = false;
            try
            {
                myConnection.Open();
                Console.WriteLine("MySQL version : {0}", myConnection.ServerVersion);
                open = true;
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
            return open;
        }

        public void CloseConnection()
        {
            myConnection.Close();
        }
    }
}
