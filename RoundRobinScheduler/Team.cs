using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Describes the team using its identification number and name.
/// </summary>
namespace RoundRobinScheduler
{
    class Team
    {
        /// <summary>
        /// Id of the team.
        /// </summary>
        public int Id
        {
            private set;
            get;
        }

        /// <summary>
        /// Team's name.
        /// </summary>
        public string Name
        {
            private set;
            get;
        }

        /// <summary>
        /// Represents the district to which the team is assigned.
        /// </summary>
        public District DistrictAssignment
        {
            private set;
            get;
        }

        /// <summary>
        /// Creates a team. The team has a name and and identification number.
        /// </summary>
        /// <param name="id">Identification number of the team</param>
        /// <param name="name">Team's name</param>
        /// <param name="da">Team's district assignment</param>
        Team(int id, string name, District da)
        {
            this.Id   = id;
            this.Name = name;
            this.DistrictAssignment = da;
        }
    }
}
