using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpeDiem
{
    class DAL
    {
        static DatabaseConnection dC = new DatabaseConnection();

        //Adds a new object to the database
        public static bool Create(Object o)
        {
            //Boolean to return
            bool created = false;
            string tableName = o.ToString();

            //Open DatabasConnection
            dC.OpenConnection();

            //Get property methods
            PropertyInfo[] fields = ModelHandler.GetPropertyInfo(o);

            //Create and concatinate SQL String from propertyinformation
            string strSql = "INSERT INTO " + tableName + " (";
            string strSeperator = "";
            foreach (PropertyInfo field in fields)
            {
                strSql += strSeperator + field.Name;
                strSeperator = ", ";
            }
            strSql += ") VALUES (";
            strSeperator = "";
            foreach (PropertyInfo field in fields)
            {
                string strValue = field.GetValue(o, null) as string;
                strSql += strSeperator + "'" + strValue + "'";
                strSeperator = ",";
            }
            strSql += ");";

            // Create SQL Command
            SqlCommand cmd = new SqlCommand(strSql, dC.myConnection);

            // Execute
            try
            {
                cmd.ExecuteNonQuery();
                created = true;
            }
            catch (SqlException sE)
            {
                throw sE;
            }
            catch (Exception eX)
            {
                throw eX;
            }

            dC.CloseConnection();
            return created;
        }

        //Finds and returns an object from the database
        public static Object Find(object source, string id)
        {
            dC.OpenConnection();

            string tableName = source.ToString();
            string pk = GetPrimaryKey(tableName);

            //Get all data from specified table and id
            string strSql = "SELECT * FROM " + tableName + " WHERE " + pk + " = @idNumber";
            SqlCommand cmd = new SqlCommand(strSql, dC.myConnection);
            Console.WriteLine(strSql);
            cmd.Parameters.AddWithValue("@idNumber", id);
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {

                while (rdr.Read())
                {
                    //Get property methods
                    PropertyInfo[] fields = ModelHandler.GetPropertyInfo(source);

                    foreach (PropertyInfo field in fields)
                    {
                        //Set properties to the values found in database
                        field.SetValue(source, rdr[field.Name].ToString(), null);
                    }
                }
            }

            dC.CloseConnection();
            return source;
        }

        //Updates object in database (parameters[] contains all values to the object's properties)
        public static bool Update(object source, string id, string[] parameters)
        {
            dC.OpenConnection();
            bool updated = false;

            string tableName = source.ToString();
            string pk = GetPrimaryKey(tableName);

            //Get property methods
            PropertyInfo[] fields = ModelHandler.GetPropertyInfo(source);

            //Create and concatinate SQL String from propertyinformation
            string sqlString = "UPDATE " + tableName + " SET ";
            string strSeperator = "";
            int i = 0;  //used to iterate through parameters[]
            foreach (PropertyInfo field in fields)
            {
                sqlString += strSeperator + field.Name + " = '" + parameters[i] + "'";
                strSeperator = ", ";
                i++;
            }
            sqlString += " WHERE " + pk + " = '" + id + "'";

            SqlCommand cmd = new SqlCommand(sqlString, dC.myConnection);
            try
            {
                cmd.ExecuteNonQuery();
                updated = true;
            }
            catch (SqlException sE)
            {
                throw sE;
            }
            catch (Exception eX)
            {
                throw eX;
            }
            dC.CloseConnection();
            return updated;
        }

        //Removes object from database
        public static bool Remove(object source, string id)
        {
            if (id is null)
            {
                throw new Exception("Please double click on the loan you want to remove");
            }

            dC.OpenConnection();
            bool remove = false;

            //Get table name and primary key column name
            string tableName = source.ToString();
            string pk = GetPrimaryKey(tableName);

            //Concatinate SQL-string and create SQL command
            string strSql = "DELETE FROM " + tableName + " WHERE " + pk + " = '" + id + "'";
            SqlCommand cmd = new SqlCommand(strSql, dC.myConnection);
            try
            {
                cmd.ExecuteNonQuery();
                remove = true;
            }
            catch (SqlException sE)
            {
                throw sE;
            }
            catch (Exception eX)
            {
                throw eX;
            }
            dC.CloseConnection();
            return remove;
        }

        //Gets the name of the primary key column from the database (i.e. itemNumber or idFromCell)
        public static string GetPrimaryKey(string tableName)
        {
            //Get column name of primary key attribute from database
            string pkSqlString = "SELECT column_name FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE OBJECTPROPERTY(OBJECT_ID(constraint_name), 'IsPrimaryKey') = 1 AND table_name = '" + tableName + "'";
            SqlCommand pkCmd = new SqlCommand(pkSqlString, dC.myConnection);
            string pk = null;
            try
            {
                pk = (string)pkCmd.ExecuteScalar();
            }
            catch (SqlException sE)
            {
                throw sE;
            }
            catch (Exception eX)
            {
                throw eX;
            }
            return pk;
        }

        public static DataTable DisplayDataTable(Object source, string args)
        {
            dC.OpenConnection();
            string tableName = source.ToString();

            string sqlString = "SELECT * FROM " + tableName;

            if (args != null)
            {
                sqlString += args;
            }

            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlString, dC.myConnection);
            DataTable dataTable = new DataTable();
            try
            {
                sqlDA.Fill(dataTable);
                dC.CloseConnection();
                return dataTable;
            }
            catch (SqlException sE)
            {
                Console.WriteLine(sE.Message);
                throw sE;
            }
            catch (Exception eX)
            {
                throw eX;
            }
        }

        public static List<string> GetAll(object source)
        {
            dC.OpenConnection();
            string tableName = source.ToString();
            List<string> info = new List<string>();

            //Get all data from specified table and id
            string strSql = "SELECT * FROM " + tableName;

            SqlCommand cmd = new SqlCommand(strSql, dC.myConnection);
            SqlDataReader rdr;
            try
            {
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    StringBuilder rowBuilder = new StringBuilder();
                    PropertyInfo[] fields = ModelHandler.GetPropertyInfo(source);

                    foreach (PropertyInfo field in fields)
                    {
                        rowBuilder.Append(rdr[field.Name].ToString() + ",");
                    }
                    //Ta bort sista ", "
                    string row = rowBuilder.ToString().Substring(0, rowBuilder.Length - 1);
                    //Addera rad till info-lista
                    info.Add(row);
                }

                dC.CloseConnection();
            }
            catch (SqlException sE)
            {
                Console.WriteLine(sE.Message);
                throw sE;
            }
            catch (Exception eX)
            {
                throw eX;
            }
            return info;
        }

    }
}


