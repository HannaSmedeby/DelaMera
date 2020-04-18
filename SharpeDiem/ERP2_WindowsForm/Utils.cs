using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP2_WindowsForm
{
    public class Utils
    {
        public static DataTable ConvertListToDataTable(WebServiceClient.ArrayOfString[] list)
        {
            // New table
            DataTable table = new DataTable();

            // Get max columns
            int columns = 0;
            foreach (var array in list)
            {
                if (array.Count > columns)
                {
                    columns = array.Count;
                }
            }

            // Add columns
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();
            }

            //Get column names
            List<string> columnNames = list[0];
            for (int i = 0; i < columns; i++)
            {
                table.Columns[i].ColumnName = columnNames[i];
            }

            //Remove the first row (column names)
            list = list.Skip(1).ToArray();

            // Add rows
            foreach (List<string> rowInformation in list)
            {
                int i = 0;
                var row = table.NewRow();
                foreach (string s in rowInformation)
                {
                    row[columnNames[i]] = s;
                    i++;
                }

                table.Rows.Add(row);
            }

            return table;
        }
        
    }
}
