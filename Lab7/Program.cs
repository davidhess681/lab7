using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Lab7
{
    class Program
    {

        // declare the regular expressions here to easily reference them elsewhere
        static string nameRegex = @"^[A-Z]+[A-z]{2,30}$";
        static string emailRegex = @"^(([\w\.\-]{5,30})+)@(([\w\-]{5,10})+)((\.(\w){2,3})+)$";
        static string phoneRegex = @"^\(?\d{3}\)?-? *\d{3}-? *-?\d{4}$";
        static string dateRegex = @"^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$";

        static void Main(string[] args)
        {
            
            ValidateNames();
            ValidateEMail();
            ValidatePhoneNums();
            ValidateDate();
            Console.WriteLine("Thank you! Press any key to close.");
            Console.ReadKey();
        }
        static bool CheckFormat(string regex)
        {
            
            string input = Console.ReadLine();

            // use Regex.IsMatch to compare the user input to the regex passed in
            if (Regex.IsMatch(input, regex)) 
            {
                return true;
            }
            else{
                
                // if wrong format, use recursion to loop the method
                Console.WriteLine("Invalid. Try again: ");
                return CheckFormat(regex);
            }
        }

        static void ValidateNames()
        {
            
            Console.WriteLine("What is your name?");

            // pass nameRegex to the CheckFormat method
            if (CheckFormat(nameRegex))
            {
                // when CheckFormat returns true we tell the user that the name is valid and proceed to the next validation method
                Console.WriteLine("Name is Valid!\n\n");
            }
            
        }

        static void ValidateEMail()
        {
            Console.WriteLine("What is your email?");
            if (CheckFormat(emailRegex))
            {
                Console.WriteLine("Email is Valid!\n\n");
            }
        }

        static void ValidatePhoneNums()
        {
            Console.WriteLine("What is your phone number? (format xxx-xxx-xxxx): ");
            if (CheckFormat(phoneRegex))
            {
                Console.WriteLine("Phone number is Valid!\n\n");
            }
        }

        static void ValidateDate()
        {
            Console.WriteLine("What is your birthday? (format dd/mm/yyyy): ");
            if (CheckFormat(dateRegex))
            {
                Console.WriteLine("Date is Valid!\n\n");
            }
        }

        
    }
}
