using System.Collections.Generic;

namespace GmcRestServicesClient.Models
{
    public class ProjectAgeGroups
    {
        /// <summary>
        /// Number of ProjectAgeGroup list items
        /// </summary>
        public int RowCount { get; set; }

        /// <summary>
        /// List of ProjectAgeGroups
        /// </summary>
        public List<ProjectAgeGroup> ProjectAgeGroupCollection { get; set; }
    }

    public class ProjectAgeGroup
    {
        /// <summary>
        /// Same value as input
        /// </summary>
        public string ProjectKey { get; set; }

        /// <summary>
        /// Youngest age the below data applies to
        /// </summary>
        public string LowAge { get; set; }
		
        /// <summary>
        /// Oldest age the below data applies to
        /// </summary>
        public string HighAge { get; set; }
		
        /// <summary>
        /// Months of the year the project is in session
        /// </summary>
        public string SchoolMonths { get; set; }
		
        /// <summary>
        /// Days of the week the project is in session
        /// </summary>
        public string SchoolDays { get; set; }

        /// <summary>
        /// How many hours the related activity meets
        /// </summary>
        public string SchoolHours { get; set; }
    }
}