using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        //member variables
        public string choice;
        Contestant contestant = new Contestant();

        //constructor
        public MarketingFirm()
        {

        }

        //member methods
        public ISweepstakes ChooseManagerType(string choice)
        {
            switch (choice.ToLower())
            {
                case "stack":
                    return new SweepstakesStackManager();
                case "queue":
                    return new SweepstakesQueueManager();
                default:
                    throw new ApplicationException(string.Format("Not a valid sweepstakes manager"));
            }
        }
    }
}
