using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RoundRobinScheduler
{
    class GroupScheduler : IScheduler
    {
        private List<Team> Teams;

        public void GenerateSchedule()
        {
            if (this.Teams == null)
                throw new InvalidOperationException();

            //TODO implement
            
            throw new NotImplementedException();
        }

        public bool LoadTeams(List<Team> Teams)
        {
            if (Teams.Count > 1)
            {
                this.Teams = Teams;
                return true;
            }
            return false;
        }
    }
}
