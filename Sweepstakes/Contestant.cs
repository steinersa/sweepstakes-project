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
