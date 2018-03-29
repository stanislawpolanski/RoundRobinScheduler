using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundRobinScheduler
{
    class Match
    {
        readonly Team HomeTeam;
        readonly Team AwayTeam;
        Result MatchResult;

        /// <summary>
        /// Initiales match. As an input comes home and away teams.
        /// </summary>
        /// <param name="ht">Home player</param>
        /// <param name="at">Away player</param>
        public Match(Team ht, Team at)
        {
            this.HomeTeam = ht;
            this.AwayTeam = at;
            this.MatchResult = new Result();
        }

        /// <summary>
        /// Tries to assign results to the match.
        /// </summary>
        public void AssignResult(int HomeScore, int AwayScore)
        {
            try
            {
                this.MatchResult = new Result(HomeScore, AwayScore);
            }
            catch(Exception e)
            {
                throw;
            }
        }
    }
}
