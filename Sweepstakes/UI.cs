using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UI
    {
        //member variables

        //member methods
        public static string GetManagerType()
        {
            Console.WriteLine("Would you like to use a stack or a queue to manage the sweepstakes?");
            string choice = Console.ReadLine();
            return choice;
        }

        public static string GetNameOfSweepstakes()
        {
            Console.WriteLine("Please enter the name of the sweepstakes: ");
            string name = Console.ReadLine();
            return name;
        }

        public static string GetFirstName()
        {
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();
            return firstName;
        }

        public static string GetLastName()
        {
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();
            return lastName;
        }

        public static string GetEmail()
        {
            Console.WriteLine("Please enter your email: ");
            string email = Console.ReadLine();
            return email;
        }

        public static string GetAddress()
        {
            Console.WriteLine("Please enter your address: ");
            string address = Console.ReadLine();
            return address;
        }
    }
}
