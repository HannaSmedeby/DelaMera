using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            WebApplication1.DAL.ERP1_DAL dal = new WebApplication1.DAL.ERP1_DAL();


            //bool b = dal.Update("SF", "Victoria", "Andersson", "Programmerare", "Barkstigen", "123");


            List<string> list = soap.Find("VA");

            foreach(String s in list)
            {

                    Console.WriteLine(s);
            }
            Console.Read();
        }
    }
}
