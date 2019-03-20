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
            ReceiveRegistrationNumber();
        }

        //member methods
        public int ReceiveRegistrationNumber()
        {
            Random random = new Random();
            registrationNumber = random.Next(0, 9999);
            return registrationNumber;
        }
    }
}
