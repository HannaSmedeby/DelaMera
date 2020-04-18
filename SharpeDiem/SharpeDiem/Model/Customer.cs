using System;
using System.Collections.Generic;
using System.Data;

namespace SharpeDiem
{
    class Customer : IModel
    {
        private string email;
        private string name;
        private string ssn;
        private string phonenumber;

        public Customer() { }

        public Customer(string email, string name, string ssn, string phonenumber)
        {
            Email = email;
            Name = name;
            Ssn = ssn;
            Phonenumber = phonenumber;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Ssn
        {
            get => ssn;
            set => ssn = value;
        }

        public string Phonenumber
        {
            get => phonenumber;
            set => phonenumber = value;
        }

        public bool Create(string[] parameters)
        {
            bool created = false;
            Customer customer = new Customer(parameters[0], parameters[1], parameters[2], parameters[3]);
            created = DAL.Create(customer);

            return created;
        }

        public object Find(string id)
        {
            Customer customer = DAL.Find(this, id) as Customer;
            if (customer != null) { return customer; }
            else { return "Did not find item"; }
        }
        public bool Update(string id, string[] parameters)
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
            return "Customer";
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
