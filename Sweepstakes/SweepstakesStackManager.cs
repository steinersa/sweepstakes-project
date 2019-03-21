using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakes
    {
        // member variables
        Stack<Sweepstakes> stack = new Stack<Sweepstakes>();
        Sweepstakes sweepstakes = new Sweepstakes("name");

        // constructor

        // member methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return stack.Pop();
        }
    }
}