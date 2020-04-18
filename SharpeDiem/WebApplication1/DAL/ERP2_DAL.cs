using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.DAL
{
    public class ERP2_DAL
    {
        public static WebApplication.DatabaseHandler.DatabaseConnection conn = new WebApplication.DatabaseHandler.DatabaseConnection();


        //DATA METHODS

        //Contents the Employee tables and related tables
        public List<List<string>> EmployeeContents(string args)
        {
            conn.OpenConnection();

            List<List<string>> allContents = new List<List<string>>();
            List<string> columnNames = new List<string>();
            List<string> contentRow = new List<string>();
            int columns = 0;

            string sqlColumns = "SELECT name FROM sys.columns WHERE OBJECT_NAME(object_id) LIKE '" + args +"'";
            SqlCommand cmd = new SqlCommand(sqlColumns, conn.myConnection);
            cmd.CommandTimeout = 0;
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                columnNames.Add(rdr.GetValue(0).ToString());
                columns++;
            }
            allContents.Add(columnNames);

            rdr.Close();

            string sqlContent = "SELECT * FROM [" + args + "]";
            cmd = new SqlCommand(sqlContent, conn.myConnection);
            cmd.CommandTimeout = 0;
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                for(int it = 0; it < columns; it++)
                {
                    contentRow.Add(rdr[columnNames[it]].ToString());
                }
                allContents.Add(contentRow);
                contentRow = new List<string>();
            }
            rdr.Close();
            return allContents;

        }

        //Information about employees and their relatives
        public List<List<string>> EmployeesRelatives()
        {
            conn.OpenConnection();

            List<List<string>> allRows = new List<List<string>>();
            List<string> row = new List<string>();

            row.Add("Employee first name");
            row.Add("Employee last name");
            row.Add("Relation");
            row.Add("Relative first name");
            row.Add("Relative last name");
            allRows.Add(row);
            row = new List<string>();

            string sqlString = "SELECT e.[First Name], e.[Last Name], r.[Relative Code], r.[First Name], r.[Last Name] FROM [CRONUS Sverige AB$Employee] e JOIN [CRONUS Sverige AB$Employee Relative] r ON e.No_ = r.[Employee No_]";

            SqlCommand cmd = new SqlCommand(sqlString, conn.myConnection);
            cmd.CommandTimeout = 0;
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                row.Add(rdr.GetString(0));
                row.Add(rdr.GetString(1));
                row.Add(rdr.GetString(2));
                row.Add(rdr.GetString(3));
                row.Add(rdr.GetString(4));

                allRows.Add(row);
                row = new List<string>();
            }
            rdr.Close();
            conn.CloseConnection();
            return allRows;
        }

        //Information about employees that have been absent due to sickness in the year of 2004
        public List<List<string>> SickEmployees()
        {
            conn.OpenConnection();

            List<List<string>> allRows = new List<List<string>>();
            List<string> row = new List<string>();

            row.Add("First name");
            row.Add("Last name");
            allRows.Add(row);
            row = new List<string>();

            string sqlString = "SELECT DISTINCT [First Name], [Last Name] FROM[CRONUS Sverige AB$Employee] e " +
                "JOIN[CRONUS Sverige AB$Employee Absence] a ON e.No_ = a.[Employee No_] WHERE a.Description " +
                "LIKE 'Sjuk' AND a.[From Date] LIKE '%2004%';";

            SqlCommand cmd = new SqlCommand(sqlString, conn.myConnection);
            cmd.CommandTimeout = 0;
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                row.Add(rdr.GetString(0));
                row.Add(rdr.GetString(1));

                allRows.Add(row);
                row = new List<string>();
            }
            rdr.Close();
            conn.CloseConnection();
            return allRows;
        }

        //First name of the employee that has been absent the most
        public List<List<string>> MostSickEmployee()
        {
            conn.OpenConnection();

            List<List<string>> allRows = new List<List<string>>();
            List<string> row = new List<string>();

            row.Add("Number of absences");
            row.Add("First name");
            allRows.Add(row);
            row = new List<string>();

            string sqlString = "SELECT TOP 1 COUNT([First Name]), [First Name] FROM[CRONUS Sverige AB$Employee] e " +
                "JOIN[CRONUS Sverige AB$Employee Absence] a ON e.No_ = a.[Employee No_] GROUP BY[First Name] " +
                "ORDER BY COUNT([First Name]) DESC";

            SqlCommand cmd = new SqlCommand(sqlString, conn.myConnection);
            cmd.CommandTimeout = 0;
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                row.Add(rdr.GetInt32(0).ToString());
                row.Add(rdr.GetString(1));

                allRows.Add(row);
                row = new List<string>();
            }
            rdr.Close();
            conn.CloseConnection();
            return allRows;
    }

        //METADATA METHODS

        // All keys - for all tables or user's choice of Employee-table
        public List<List<string>> GetAllKeys(string args)
        {
            conn.OpenConnection();

            List<List<string>> allKeys = new List<List<string>>();
            List<string> key = new List<string>();

            key.Add("Type of key");
            key.Add("Key name");
            key.Add("Table name");
            allKeys.Add(key);
            key = new List<string>();
 
            string sqlString = "SELECT k.type_desc, k.name, t.name FROM sys.key_constraints k JOIN sys.tables t On k.parent_object_id = t.object_id ";

            if (args != null)
            {
                sqlString += " WHERE t.name LIKE '";
                sqlString += args + "'";
            }

            SqlCommand cmd = new SqlCommand(sqlString, conn.myConnection);
            cmd.CommandTimeout = 0;
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                key.Add(rdr.GetString(0));
                key.Add(rdr.GetString(1));
                key.Add(rdr.GetString(2));
                allKeys.Add(key);

                key = new List<string>();
            }
            rdr.Close();
            conn.CloseConnection();
            return allKeys;
        }

        //All indexes - for all tables or user's choice of Employee-table 
        public List<List<string>> AllIndexes(string args)
        {
            conn.OpenConnection();
            List<List<string>> allIndexes = new List<List<string>>();
            List<string> index = new List<string>();

            index.Add("Table name");
            index.Add("Index name");
            index.Add("Index id");
            index.Add("Column id");
            index.Add("Column name");
            allIndexes.Add(index);
            index = new List<string>();

            string sqlString = "SELECT TableName = t.name, IndexName = ind.name, IndexId = ind.index_id, ColumnId = ic.index_column_id, " +
                "ColumnName = col.name " +
                "FROM sys.indexes ind INNER JOIN sys.index_columns ic ON ind.object_id = ic.object_id and ind.index_id = ic.index_id " +
                "INNER JOIN sys.columns col ON ic.object_id = col.object_id and ic.column_id = col.column_id " +
                "INNER JOIN sys.tables t ON ind.object_id = t.object_id";


            if (args != null)
            {
                sqlString += " WHERE t.Name LIKE '";
                sqlString += args +"'";
            }

            SqlCommand cmd = new SqlCommand(sqlString, conn.myConnection);
            cmd.CommandTimeout = 0;
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                index.Add(rdr.GetString(0));
                index.Add(rdr.GetString(1));
                index.Add(rdr.GetInt32(2).ToString());
                index.Add(rdr.GetInt32(3).ToString());
                index.Add(rdr.GetString(4));
                allIndexes.Add(index);

                index = new List<string>();
            }
            rdr.Close();
            conn.CloseConnection();
            return allIndexes;
        }

        //All table_constraints - for all tables or user's choice of Employee-table
        public List<List<string>> AllConstraints(string args)
        {
            conn.OpenConnection();

            List<List<string>> allConstraints = new List<List<string>>();
            List<string> constraint = new List<string>();

            constraint.Add("Constraint name");
            constraint.Add("Table name");
            allConstraints.Add(constraint);
            constraint = new List<string>();

            string sqlString = "SELECT CONSTRAINT_NAME, TABLE_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS";
            if (args != null)
            {
                sqlString += " WHERE TABLE_NAME LIKE '";
                sqlString += args + "'";
            }

            SqlCommand cmd = new SqlCommand(sqlString, conn.myConnection);
            cmd.CommandTimeout = 0;
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                constraint.Add(rdr.GetString(0));
                constraint.Add(rdr.GetString(1));
                allConstraints.Add(constraint);

                constraint = new List<string>();
            }
            rdr.Close();
            conn.CloseConnection();
            return allConstraints;
        }

        //All tables in the database (two different solutions required)
        public List<List<string>> AllTableNames1()
        {
            conn.OpenConnection();

            List<List<string>> tableNames = new List<List<string>>();
            List<string> tableName = new List<string>();

            tableName.Add("Table name");
            tableNames.Add(tableName);
            tableName = new List<string>();

            string sqlString = "SELECT name FROM sys.tables";

            SqlCommand cmd = new SqlCommand(sqlString, conn.myConnection);
            cmd.CommandTimeout = 0;
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                tableName.Add(rdr.GetString(0));
                tableNames.Add(tableName);
                tableName = new List<string>();
            }
            rdr.Close();
            conn.CloseConnection();
            return tableNames;
        }

        // All tables in the database (two different solutions required)
        public List<List<string>> AllTableNames2()
        {
            conn.OpenConnection();

            List<List<string>> tableNames = new List<List<string>>();
            List<string> tableName = new List<string>();

            tableName.Add("Table name");
            tableNames.Add(tableName);
            tableName = new List<string>();

            string sqlString = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";

            SqlCommand cmd = new SqlCommand(sqlString, conn.myConnection);
            cmd.CommandTimeout = 0;
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                tableName.Add(rdr.GetString(0));
                tableNames.Add(tableName);
                tableName = new List<string>();
            }
            rdr.Close();
            conn.CloseConnection();
            return tableNames;
        }

        //All columns of the Employee table(two different solutions required)
        public List<List<string>> AllEmployeeColumns1()
        {
            conn.OpenConnection();

            List<List<string>> columnNames = new List<List<string>>();
            List<string> columnName = new List<string>();

            columnName.Add("Column name");
            columnNames.Add(columnName);
            columnName = new List<string>();

            string sqlString = "SELECT [COLUMN_NAME] FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME LIKE 'CRONUS Sverige AB$Employee'";

            SqlCommand cmd = new SqlCommand(sqlString, conn.myConnection);
            cmd.CommandTimeout = 0;
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                columnName.Add(rdr.GetString(0));
                columnNames.Add(columnName);
                columnName = new List<string>();
            }
            rdr.Close();
            conn.CloseConnection();
            return columnNames;
        }

        //All columns of the Employee table (two different solutions required) 
        public List<List<string>> AllEmployeeColumns2()
        {
            conn.OpenConnection();

            List<List<string>> columnNames = new List<List<string>>();
            List<string> columnName = new List<string>();

            columnName.Add("Column name");
            columnNames.Add(columnName);
            columnName = new List<string>();

            string sqlString = "SELECT col.name FROM sys.objects obj INNER JOIN sys.columns col ON col.object_id = obj.object_id AND obj.name LIKE 'CRONUS Sverige AB$Employee'";

            SqlCommand cmd = new SqlCommand(sqlString, conn.myConnection);
            cmd.CommandTimeout = 0;
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                columnName.Add(rdr.GetString(0));
                columnNames.Add(columnName);
                columnName = new List<string>();
            }
            rdr.Close();
            conn.CloseConnection();
            return columnNames;
        }

        //Returns all names of the Employee tables in the database
        public List<string> EmployeeTables()
        {
            conn.OpenConnection();

            List<string> tableNames = new List<string>();

            string sqlString = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME " +
                "LIKE 'CRONUS Sverige AB$Employ%' ORDER BY TABLE_NAME";

            SqlCommand cmd = new SqlCommand(sqlString, conn.myConnection);
            cmd.CommandTimeout = 0;
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                tableNames.Add(rdr.GetString(0));
            }
            rdr.Close();
            conn.CloseConnection();
            return tableNames;
        }
    }
}