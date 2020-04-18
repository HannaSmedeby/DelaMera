
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2
{
    class DAL
    {
        DatabaseConnection dC = new DatabaseConnection();
        DataTable showRows = new DataTable();
        private int count;
        List<String> columnNames = new List<String>();


        public object[] getTablesOfInterest()
        {
            dC.OpenConnection();

            String sqlString = "SELECT TableName FROM TablesOfInterest";

            List<String> list = new List<String>();
            using (var command = new SqlCommand(sqlString, dC.myConnection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String s = reader["tableName"].ToString();
                        list.Add(s);
                    }
                }

            }
            dC.CloseConnection();

            object[] objList = new object[list.Count];
            int i = 0;
            foreach (string s in list)
            {
                objList[i] = s;
                i++;
            }

            return objList;
        }

        public List<String> getColumnNames(string tableName)
        {
            dC.OpenConnection();
            columnNames = new List<string>();

            {

                String sqlString = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME LIKE '" + tableName + "'";

                using (var command = new SqlCommand(sqlString, dC.myConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                columnNames.Add(reader.GetValue(i).ToString());
                            }
                        }
                    }

                }


            }
            dC.CloseConnection();
            return columnNames;

        }

        public int getTableRows(String tableName)
        {

            String sqlString = "SELECT COUNT(*) FROM " + tableName;

            using (var command = new SqlCommand(sqlString, dC.myConnection))
            {

                dC.OpenConnection();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }


            }


            dC.CloseConnection();
            return count;
        }
        /*
         public int TableRows()
         {

             using (SqlConnection connect = new SqlConnection(DatabaseConnection.connectionString))
             {
                 connect.Open();
                 using (SqlCommand command = new SqlCommand("SELECT COUNT* FROM TablesOfInterest", connect))
                 {
                     SqlDataReader sqlreader = command.ExecuteReader();

                     while (sqlreader.Read())
                     {
                         for (int i = 0; i < sqlreader.FieldCount; i++)
                         {

                             count++;
                         }
                     }
                     sqlreader.Close();
                 }
             }
             return count;
         }

     */
    }
}