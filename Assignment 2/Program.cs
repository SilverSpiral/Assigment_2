using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string Login = "Niklas Kjærgaard";
            string Password = "Rabbit";

            CarStock myCarStock = new CarStock();

            Console.WriteLine("Please provide username to access" + " the BrandX system");
            Console.Write("Username:");
            string LoginAttempt = Console.ReadLine();
            Console.WriteLine("Please provide password");
            Console.Write("Password: ");
            string PassAttempt = Console.ReadLine();
            if (LoginAttempt != Login && Password != PassAttempt)
            {
                Console.WriteLine("You are not authorized to access this service");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n\n\n");
                myCarStock.LoginSuccess();
                Console.ReadLine();
            }

        }
    }
}



