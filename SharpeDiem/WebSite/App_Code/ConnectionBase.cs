using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


class ConnectionBase
{
    
       private static string connString = GetConnectionString(); //connection string to SQL-Database


    public static SqlConnection OpenSQLConnection()
    {
        try
        {
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = connString;
            connect.Open();
            return connect;
        }
        catch (SqlException sql)
        {
            Console.WriteLine(sql.ToString());
            return null;
        }
    }
    static string GetConnectionString()
    {
        return "server=SYST4DEV01; database=DatabaseProject; Trusted_Connection=Yes;"; //connection info (path, host and port, credentials
    }


    public string DataReader1(string query)
    {
        try
        {
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand();
            command.Connection = OpenSQLConnection();
            command.CommandText = query;
            string s = "";
           


            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                 
                    s += "\nItem number: " + reader[0].ToString() + "\n";
                    s += "Category: " + reader[1].ToString() + "\n";
                    s += "Color: " + reader[2].ToString() + "\n";
                    s += "Conditiom: " + reader[3].ToString() + "\n";
                    s += "Description: " + reader[4].ToString() + "\n";
                    s += "Item status : " + reader[5].ToString() + "\n";
                    s += "\n";
                   
                   
                }
                return s;
            }
            else
            {
                return "No result.";
            }
        }
        catch (SqlException sql)
        {

            return sql.Message;
        }
        catch (Exception ex)
        {
            return ex.Message;



        }
        finally
        {
            OpenSQLConnection().Close();
        }
    }

    public string ItemQuery()
    {
        string query = "SELECT * FROM Item";
        return DataReader1(query);
        
    }

    public string DataReader2(string query)
    {
        try
        {
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand();
            command.Connection = OpenSQLConnection();
            command.CommandText = query;
            string s = "";
            


            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    s += "\nLoan number: " + reader[0].ToString() + "\n";
                    s += "Borrow date: " + reader[1].ToString() + "\n";
                    s += "Return date: " + reader[2].ToString() + "\n";
                    s += "Customer email: " + reader[3].ToString() + "\n";
                    s += "Item number: " + reader[4].ToString() + "\n";
                   
                    s += "\n";
                    

                }
                return s;
            }
            else
            {
                return "No result. ";
            }
        }
        catch (SqlException sql)
        {

            return sql.Message;
        }
        catch (Exception ex)
        {
            return ex.Message;



        }
        finally
        {
            OpenSQLConnection().Close();
        }
    }

    public string LoanQuery()
    {
        string query = "SELECT * FROM Loan";
        return DataReader2(query);

    }





}

   