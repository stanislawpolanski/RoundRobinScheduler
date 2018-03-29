using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundRobinScheduler
{
    /// <summary>
    /// Contains specific league metadata and its rounds to play.
    /// </summary>
    class League
    {
        int Id;
        string Name;
        Season LeagueSeason;
        List<Round> Rounds;

        public League(int id, string name, Season ls, List<Round> rounds) : this(id, name, ls)
        {
            this.Rounds = rounds;
        }

        public League(int id, string name, Season ls)
        {
            this.Id = id;
            this.Name = name;
            this.LeagueSeason = ls;
        }
    }
}
