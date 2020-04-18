using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpeDiem
{
    class Controller
    {
        Item item = new Item();
        Loan loan = new Loan();

        //Constructor
        public Controller()
        {
        }

        //CreateItem metod 
        public bool CreateItem(string[] parameters)
        {
            return item.Create(parameters);
        }

        //CreateLoan metod
        public bool CreateLoan(string[] parameters)
        {        
            return loan.Create(parameters);
        }
        
        //FindItem 
        public Item FindItem(string id) 
        {
            Item i = item.Find(id) as Item;
            if (item.Color != null) { return item; }
            else { throw new Exception("Item does not exist in database"); }
        } 

        //FindLoan
        public Object FindLoan(string id) 
        {
            return loan.Find(id);
        }

        //UpdateItem metod
        public bool UpdateItem(string id, string[] parameters) 
        {
            return item.Update(id, parameters);
        }
        //UpdateLoan
        public bool UpdateLoan(string id, string [] parameters)
        {
            return loan.Update(id, parameters);
        }

        //RemoveItem metod
        public bool RemoveItem(string id)
        {
            return item.Remove(id);
        }

        //RemoveLoan
        public bool RemoveLoan(string id)
        {
            return loan.Remove(id);
        }
         
        //Get primary keys from table
        public String GetPrimaryKey(string tableName)
        {
            return DAL.GetPrimaryKey(tableName);
        }


        public string GetAvailableItems(DateTime borrowDate, DateTime returnDate)
        {
            Item i = new Item();
            string available = i.GetAvailableItems(borrowDate, returnDate);
            return available;
        }

        public DataTable DisplayItems(string args)
        {
            return item.DisplayDataTable(args);
        }

        public DataTable DisplayLoans(string args)
        {
            return loan.DisplayDataTable(args);
        }

    }
}
