using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SharpeDiem
{
    class Item : IModel
    {
        private string itemNumber;
        private string category;
        private string color;
        private string condition;
        private string description;
        private string size;

        public Item() { }

        public Item(string category, string color, string condition, string description, string size)
        {
            ItemNumber = GenerateID(category); // Ska autogenereras
            Category = category;
            Color = color;
            Condition = condition;
            Description = description;
            Size = size;
        }


        public string ItemNumber
        {
            get => itemNumber;
            private set => itemNumber = value;
        }

        public string Category
        {
            get => category;
            set => category = value;
        }

        public string Color
        {
            get => color;
            set => color = value;
        }

        public string Condition
        {
            get => condition;
            set => condition = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }


        public String Size
        {
            get => size;
            set => size = value;
        }

        public bool Create(string [] parameters)
        {
            bool created = false;
            Item item = new Item(parameters[0], parameters[1], parameters[2], parameters[3], parameters[4]);
            created = DAL.Create(item);
            
            return created;
        }

        public object Find(string id)
        {
            Object o = DAL.Find(this, id);
            return o;
        }

        public bool Update(string id, string [] parameters)
        {

            bool b = DAL.Update(this, id, parameters);
            return b;
        }

        public bool Remove(string id)
        {
            bool b = DAL.Remove(this, id);
            return b;
        }

        public override string ToString()
        {
            return "Item";
        }

        public static string GenerateID(string category)
        {
            Random random = new Random();
            string itemCategory = category.ToString().Substring(0, 2); //First two category-letters
            int num = random.Next(1000); // Returns a random number under 1000
            string id = itemCategory.ToUpperInvariant() + num.ToString();
            return id;
        }

        public string GetAvailableItems(DateTime borrowDate, DateTime returnDate)

        {
            Loan loan = new Loan();
            List<object> loaned = loan.GetAll();
            List<string> notAvailable = new List<string>();
            StringBuilder argBuilder = new StringBuilder();
            argBuilder.Append(" WHERE itemNumber NOT IN ( ");
            string args = null;

            //Loop through all loans
            foreach (Object obj in loaned)
            {
                loan = obj as Loan;

                //Check if requested dates are within the timespan of current loan
                //If the timespans overlaps -> add the Item to the notAvailable-list
                if (borrowDate <= Convert.ToDateTime(loan.BorrowDate)) {
                    if (returnDate >= Convert.ToDateTime(loan.BorrowDate))
                    {
                        notAvailable.Add(loan.ItemNumber);
                    }
                } else if (borrowDate >= Convert.ToDateTime(loan.BorrowDate)){
                    if (borrowDate <= Convert.ToDateTime(loan.ReturnDate))
                    {
                        notAvailable.Add(loan.ItemNumber);
                    }
                }
                //Build SQL-string fetching all info from Item except the unavailable Item's
                if (!notAvailable.Count.Equals(0))
                {
                    foreach (string itemNbr in notAvailable)
                    {
                        argBuilder.Append(" '" + itemNbr + "',");
                    }

                    args = argBuilder.ToString().Substring(0, argBuilder.Length - 1);
                    args += " );";
                }
            }
            //Return SQL-argument
            return args;
        }

        public DataTable DisplayDataTable(string args)
        {
            DataTable data = DAL.DisplayDataTable(this, args);
            if (data.Rows.Count < 1)
            {
                NullReferenceException n = new NullReferenceException();
                throw n;
            }
            else
            {
                return data;
            }
        }
    }
}