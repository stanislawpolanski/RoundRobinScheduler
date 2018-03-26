using System;

namespace RoundRobinScheduler
{
    class Result
    {
        /// <summary>
        /// Stores results of the match
        /// </summary>
        private Tuple<int?, int?> Scores;

        /// <summary>
        /// Generates blank result
        /// </summary>
        public Result()
        {
            this.Scores = new Tuple<int?, int?>(null, null);
        }

        /// <summary>
        /// Generates result of the match
        /// </summary>
        /// <param name="HomeScore">Goals of home team</param>
        /// <param name="AwayScore">Goals of away team</param>
        public Result(int HomeScore, int AwayScore)
        {
            if (this.ValidateResults(HomeScore, AwayScore))
                this.Scores = new Tuple<int?, int?>(HomeScore, AwayScore);
            //TODO if not proper then throw out an exception
        }

        /// <summary>
        /// Internal validation of match scores. Checks if the results are >=0.
        /// </summary>
        /// <param name="homeScore">Goals of home team</param>
        /// <param name="awayScore">Goals of away team</param>
        /// <returns></returns>
        private bool ValidateResults(int homeScore, int awayScore)
        {
            //TODO must be implemented
            throw new NotImplementedException();
        }
    }
}