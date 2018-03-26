using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//TODO is there a need to store it as a 
namespace RoundRobinScheduler
{
    class Round : List<Match>
    {
        public readonly int OrdinalNumber;

        public Round(int on)
        {
            if (on > 0)
                this.OrdinalNumber = on;
            else
                throw new Exception();
            //TODO some special exception?
        }
    }
}
