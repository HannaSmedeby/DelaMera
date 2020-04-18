using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ERP1_WindowsForm
{
    class Utils
    {
        public DataTable ConvertListToDataTable(List<List<string>> list)
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

            IEnumerable<List<string>> l = list.Skip(1);

            // Add rows
            foreach (List<string> rowInformation in l)
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
