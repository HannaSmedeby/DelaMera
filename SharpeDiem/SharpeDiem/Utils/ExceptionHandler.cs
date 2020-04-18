
using System;
using System.Data.SqlClient;
using System.Text;

namespace SharpeDiem
{
    class ExceptionHandler
    {
        private const int INFORMATION_MISSING = 213;
        private const int PRIMARY_KEY_VIOLATION = 1062;
        private const int FOREIGN_KEY_VIOLATION = 547; 
        private const int ENTRY_TOO_LONG = 8152;

        public string ExceptionMessage(SqlException s)
        {
            string errorMessage = "";
            Console.WriteLine(s.Number);

            switch (s.Number)
            {
                case INFORMATION_MISSING:
                    errorMessage = "Please enter valid data in all fields";
                    Console.WriteLine(errorMessage);
                    return errorMessage;
                case PRIMARY_KEY_VIOLATION:
                    errorMessage = "Something went wrong generating id-number, click 'CREATE' again";
                    Console.WriteLine(errorMessage);
                    return errorMessage;
                case ENTRY_TOO_LONG:
                    errorMessage = "Entry is too long";
                    Console.WriteLine(s.Message);
                    return errorMessage;
                case FOREIGN_KEY_VIOLATION:
                    errorMessage = "Please double click on the item you want to select";
                    Console.WriteLine(s.Message);
                    return errorMessage;
                default:
                    errorMessage = "Oops something went wrong, try again";
                    Console.WriteLine(errorMessage);
                    Console.WriteLine(s.ErrorCode);
                    return errorMessage;
            }
        }

        
        public string ExceptionMessage(Exception e)
        {
            string errorMessage = "";
            Console.WriteLine(e.Message);

            if (!(e is NullReferenceException))
            {
                errorMessage = e.Message;
                return errorMessage;
            }
            else
            {
                errorMessage = "Didn't find any match!";
                Console.WriteLine(errorMessage);
                return errorMessage;
            }
            
        

        }
        
        
    }
}