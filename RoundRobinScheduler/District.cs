namespace RoundRobinScheduler
{
    public class District
    {
        /// <summary>
        /// Disctrict's id.
        /// </summary>
        public int Id
        {
            get;
            private set;
        }

        /// <summary>
        /// Name of the district
        /// </summary>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates a district.
        /// </summary>
        /// <param name="id">Id of the district</param>
        /// <param name="name">Name of the district</param>
        District(int id, string name)
        {
            this.Id   = id;
            this.Name = name;
        }
    }
}