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
        public int winningRegistrationNumber;
        public Contestant contestant;
        public Dictionary<int, Contestant> contestants;
        public Contestant winner;

        //constructor
        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            this.name = name;
        }

        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber, contestant);
        }

        public string PickWinner()
        {
            Random random = new Random();
            winningRegistrationNumber = random.Next(0, 10000);
            if(contestants.ContainsKey(winningRegistrationNumber))
            {
                winner = contestants[winningRegistrationNumber];
            }
            return "Congrats " + winner.firstName + "! You are the winner of the sweepstakes!";
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
