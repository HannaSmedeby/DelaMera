using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpeDiem
{
    class Loan: IModel
    {

        private string loanNumber;
        private string borrowDate;
        private string returnDate;
        private string itemNumber;
        private string customerEmail;

        public Loan() { }
        public Loan(string borrowDate, string returnDate, string itemNumber)
        {
            LoanNumber = GenerateID();
            BorrowDate = borrowDate;
            ReturnDate = returnDate;
            ItemNumber = itemNumber;
            CustomerEmail = "hej@bagis.se";
        }

        public string LoanNumber
        {
            get => loanNumber;
            private set => loanNumber = value;
        }
        public string BorrowDate
        {
            get => borrowDate;
            set => borrowDate = value;
        }
        public string ReturnDate
        {
            get => returnDate;
            set => returnDate = value;
        }

        public string ItemNumber
        {
            get => itemNumber;
            set => itemNumber = value;
        }

        public string CustomerEmail
        {
            get => customerEmail;
            set => customerEmail = value;
        }

        public bool Create(string [] parameters)
        {
            bool created = false;

            Loan loan = new Loan(parameters[0], parameters[1], parameters[2]);
            created = DAL.Create(loan);

            return created;
        }

        public object Find(string id)
        {
            Loan loan = DAL.Find(this, id) as Loan;
            if (loan.ItemNumber != null) { return loan; }
            else { return "Did not find item"; }
        }

        public bool Update(string id, string[] parameters)
        {
            Loan loan = this.Find(id) as Loan;

            string[] allParameters = new string[5];
            allParameters[0] = id;
            allParameters[1] = parameters[0];
            allParameters[2] = parameters[1];
            allParameters[3] = parameters[2];
            allParameters[4] = this.CustomerEmail;

            bool b = DAL.Update(this, id, allParameters);
            return b;
        }
        public bool Remove(string id)
        {
            bool b = DAL.Remove(this, id);
            return b;
        }
        public override string ToString()
        {
            return "Loan";
        }

        public static string GenerateID()
        {
            Random random = new Random();          
            int num = random.Next(10000); // Returns a random number under 10000
            string id = "LO" + num.ToString();
            return id;
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

        public List<object> GetAll()
        {
            List<object> loans = new List<object>();
            List<string> loanStrings = DAL.GetAll(this);
            foreach (string s in loanStrings)
            {
                Loan l = new Loan();
                string[] values = s.Split(',');
                l.LoanNumber = values[0];
                l.BorrowDate = values[1];
                l.ReturnDate = values[2];
                l.ItemNumber = values[3];
                l.CustomerEmail = values[4];

                loans.Add(l);
            }
            return loans;
        }

    }
}
