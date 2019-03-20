using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        //member variables
        public string name;
        public Contestant contestant;

        //constructor
        public Sweepstakes(string name)
        {
            this.name = name;
        }

        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            contestant = new Contestant();
            Dictionary<int, string> contestants = new Dictionary<int, string>();
            contestants.Add(contestant.registrationNumber, contestant.lastName);
        }

        //public string PickWinner()
        //{
            
        //}

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
