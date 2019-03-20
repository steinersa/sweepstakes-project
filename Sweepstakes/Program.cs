using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = UI.GetManagerType();
            string firstName = UI.GetFirstName();
            string lastName = UI.GetLastName();
            string email = UI.GetEmail();
            string address = UI.GetAddress();

            MarketingFirm marketingFirm = new MarketingFirm(/*manager*/);
        }
    }
}
