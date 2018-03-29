using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RoundRobinScheduler
{
    class Round : List<Match>
    {
        /// <summary>
        /// Number that represents the order of the Round in Schedule. Typically, the next matchweek should
        /// increase this number by one.
        /// </summary>
        public readonly int OrdinalNumber;

        public Round(int on)
        {
            if (on > 0)
                this.OrdinalNumber = on;
            else
                throw new ArgumentOutOfRangeException();
        }
    }
}
