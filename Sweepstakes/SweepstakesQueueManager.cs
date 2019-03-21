using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakes
    {
        // member variables
        Queue<Sweepstakes> queue = new Queue<Sweepstakes>();
        Sweepstakes sweepstakes = new Sweepstakes("name");

        // constructor

        // member methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return queue.Dequeue();
        }
    }
}
