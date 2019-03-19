using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        //member variables
        public string firstName;
        public string lastName;
        public string email;
        public string address;
        public int registrationNumber;

        //constructor
        public Contestant()
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.address = address;
            this.registrationNumber = registrationNumber;
        }

        //member methods
        public string ReceiveFirstName()
        {
            Console.WriteLine("Please enter your first name: ");
            firstName = Console.ReadLine();
            return firstName;
        }

        public string ReceiveLastName()
        {
            Console.WriteLine("Please enter your last name: ");
            lastName = Console.ReadLine();
            return lastName;
        }

        public string ReceiveEmail()
        {
            Console.WriteLine("Please enter your email: ");
            email = Console.ReadLine();
            return email;
        }

        public string ReceiveAddress()
        {
            Console.WriteLine("Please enter your address: ");
            address = Console.ReadLine();
            return address;
        }

        public int ReceiveRegistrationNumber()
        {
            registrationNumber = RandomNumber(0000, 9000);
            return registrationNumber;
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
