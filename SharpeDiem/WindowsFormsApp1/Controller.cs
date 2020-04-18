using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Uppgift2
{
    class Controller
    {
        DAL dal = new DAL();

        public Controller()
        {

        }

        public object[] getTablesOfInterest()
        {
            return dal.getTablesOfInterest();
        }

        public List<String> getColumnNames(String tableName)
        {
            return dal.getColumnNames(tableName);
        }

        public int getTableRows(String tableName)
        {
            return dal.getTableRows(tableName);
        }
     
    }
}