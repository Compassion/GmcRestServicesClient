using System.Collections.Generic;

namespace GmcRestServicesClient.Models
{
    public class ProjectAgeGroups
    {
        public int RowCount { get; set; }

        public List<ProjectAgeGroup> ProjectAgeGroupCollection { get; set; }
    }

    public class ProjectAgeGroup
    {
        public string ProjectKey { get; set; }

        public string LowAge { get; set; }
		
        public string HighAge { get; set; }
		
        public string SchoolMonths { get; set; }
		
        public string SchoolDays { get; set; }

        public string SchoolHours { get; set; }
    }
}