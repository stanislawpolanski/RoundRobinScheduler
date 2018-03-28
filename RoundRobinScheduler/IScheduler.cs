using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundRobinScheduler
{
    interface IScheduler
    {
        bool LoadTeams(List<Team> Teams);
        void GenerateSchedule();
    }
}
