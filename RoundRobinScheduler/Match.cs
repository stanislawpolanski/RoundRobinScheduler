using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundRobinScheduler
{
    class Match
    {
        //TODO give accessors
        Team HomeTeam;
        Team AwayTeam;
        Result MatchResult;

        public Match()
        {
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
                //TODO throw out new exception
            }
        }
    }
}
