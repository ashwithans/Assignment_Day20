using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySharedLibrary;

namespace MainApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userEmail = "example@example.com";
            DataValidator validator = new DataValidator();

            bool isValid = validator.IsValidEmail(userEmail);

            if (isValid)
            {
                Console.WriteLine("Valid email address!");
            }
            else
            {
                Console.WriteLine("Invalid email address!");
            }

            Console.ReadKey();
        }
    }
}
