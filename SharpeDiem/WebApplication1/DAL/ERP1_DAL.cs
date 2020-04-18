using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace WebApplication1.DAL
{
    public class ERP1_DAL
    {

        static WebApplication.DatabaseHandler.DatabaseConnection connection = new WebApplication.DatabaseHandler.DatabaseConnection();

        //Returns true if employee is created 
        public bool Create(string initials, string name, string lastName, string title, string address, string phoneNumber)
        {
            //Bool to return
            bool created = false;

            connection.OpenConnection();

            //SQL string to create Employee
            string sqlString = "INSERT INTO[CRONUS Sverige AB$Employee]([No_],[First Name],[Middle Name],[Last Name],[Initials]," +
                "[Job Title],[Search Name],[Address],[Address 2],[City],[Post Code],[County],[Phone No_],[Mobile Phone No_],[E-Mail]," +
                "[Alt_ Address Code],[Alt_ Address Start Date],[Alt_ Address End Date],[Picture],[Birth Date],[Social Security No_]," +
                "[Union Code],[Union Membership No_],[Sex],[Country_Region Code],[Manager No_],[Emplymt_ Contract Code]," +
                "[Statistics Group Code],[Employment Date],[Status],[Inactive Date],[Cause of Inactivity Code],[Termination Date]," +
                "[Grounds for Term_ Code],[Global Dimension 1 Code],[Global Dimension 2 Code],[Resource No_],[Last Date Modified]," +
                "[Extension],[Pager],[Fax No_],[Company E-Mail],[Title],[Salespers__Purch_ Code],[No_ Series]) " +
                "VALUES('"+initials+"','"+name+"','','"+lastName+"','','"+title+"','','"+address+"','','','','','"+phoneNumber+"','','','','','','','','',''," +
                "'','','','','','','','','','','','','','','','','','','','','','','')";

            SqlCommand sqlCommand = new SqlCommand(sqlString, connection.myConnection);
            
            //Try to execute query, if not possible false will be returned. 
            try
            {
                sqlCommand.ExecuteNonQuery();
                created = true;
            }
            catch
            {
                created = false;
            }

            connection.CloseConnection();
            return created;  
        }


        public List<string> Find(string id)
        {
            connection.OpenConnection();

            List<string> employee = new List<string>();

            String sqlString = "SELECT [No_], [First Name], [Last Name],[Job Title], [Address], [Phone No_] FROM[CRONUS Sverige AB$Employee] WHERE [No_] = '" + id + "'" ;
            SqlCommand cmd = new SqlCommand(sqlString, connection.myConnection);

            cmd.CommandTimeout = 0;
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            while(sqlDataReader.Read())
            {
                for(int it = 0; it<6;it++)
                {
                    employee.Add(sqlDataReader.GetValue(it).ToString());
                }
            }



            sqlDataReader.Close();
            connection.CloseConnection();
            return employee;
        }

        public List<List<String>> Read()
        {
            connection.OpenConnection();

            //List with strings holding value of every row. 
            List<string> row = new List<String>();

            //List containging names of columns. 
            List<String> columnNames = new List<string>();

            //List containing all information about table.
            List<List<String>> allContents = new List<List<String>>();
             
            string no_ = "No_";
            string firstName = "First Name";
            string lastName = "Last name";
            string jobTitle = "Job title";
            string address = "Address";
            string phoneNbr = "Phone Number";

            columnNames.Add(no_);
            columnNames.Add(firstName);
            columnNames.Add(lastName);
            columnNames.Add(jobTitle);
            columnNames.Add(address);
            columnNames.Add(phoneNbr);

            //Adds names to columnNames list
            allContents.Add(columnNames);
            
            //Sql string to get information from table
            string sqlString = "SELECT [No_], [First Name], [Last Name],[Job Title], [Address], [Phone No_] FROM[CRONUS Sverige AB$Employee]";
            SqlCommand cmd = new SqlCommand(sqlString, connection.myConnection); 

            cmd.CommandTimeout = 0;
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                for (int it = 0; it < 6; it++)
                {
                    row.Add(sqlDataReader.GetValue(it).ToString());
                }

                allContents.Add(row);
                row = new List<string>();
            }
            sqlDataReader.Close();
            connection.CloseConnection();

            return allContents;
        }

        //Returns true if object was updated
        public bool Update(string initials, string name, string lastName, string title, string address, string phoneNumber)
        {
            bool created = false;
            connection.OpenConnection();

            String sqlString = "UPDATE[CRONUS Sverige AB$Employee] SET [First Name] = '"+name+"', [Last Name] = '"+lastName+"', " +
                "[Job Title] = '"+title+"', [Address] = '"+address+"', [Phone No_] = '"+phoneNumber+"'" +
                "WHERE No_ = '"+initials+"'";

            SqlCommand sqlCommand = new SqlCommand(sqlString, connection.myConnection);

            try
            {
                sqlCommand.ExecuteNonQuery();
                created = true;
            }
            catch
            {
                created = false;
            }

            connection.CloseConnection();

            return created;
        }

        //Returns true if object is deleted
        public bool Delete(string id)
        {
            bool created = false;

            connection.OpenConnection();

            string sqlString = "DELETE FROM[CRONUS Sverige AB$Employee] WHERE No_ = '" + id + "'";

            SqlCommand sqlCommand = new SqlCommand(sqlString, connection.myConnection);

            try
            {
                sqlCommand.ExecuteNonQuery();
                created = true;
            }
            catch
            {
                created = false;
            }


            connection.CloseConnection();
            return created;
        }

    }
}