using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public interface Isweepstakes
    {
        void InsertSweepstakes(Sweepstakes sweepstakes);
        Sweepstakes GetSweepstakes();
    }
}
