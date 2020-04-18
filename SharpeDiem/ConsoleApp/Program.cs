using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
       public static void Main(string[] args)
        {
            ServiceReference.WebServiceSoapClient service = new ServiceReference.WebServiceSoapClient();

            while (true)
            {
                Console.WriteLine("Press 1 for Web Service Assignment 1.\n" +
                    "Press 2 for Web Service Assignment 2.");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("\nPlease fill out a document name: ");
                    string str = Console.ReadLine();
                    Console.WriteLine("\nOutput: " + service.GetFile(str) + "\n");

                }

                if (choice == "2")
                {

                    Console.WriteLine("\nFor item table content please press 1. \n" +
                        "For loan table content please press 2.");
                    string secondchoice = Console.ReadLine();

                    if (secondchoice == "1")
                    { 
                        Console.WriteLine(service.GetItemForConsole());
                        
                    }

                    if(secondchoice == "2")
                    {
                        Console.WriteLine(service.GetLoanForConsole());
                    }
                     
                    }
                }
           }
        }
    
}
                    
                    

                        

                    
