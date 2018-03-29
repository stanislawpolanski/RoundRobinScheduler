using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundRobinScheduler
{
    class Season
    {
        public int Id
        {
            private set;
            get;
        }
        public string Name
        {
            private set;
            get;
        }

        public Season(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
