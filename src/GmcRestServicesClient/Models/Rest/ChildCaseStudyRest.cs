using System.Collections.Generic;

namespace GmcRestServicesClient.Models.Rest
{
    public class ChildCaseStudyRest
    {
        public int ChildID { get; set; }

        public string ChildKey { get; set; }

        public string ChildName { get; set; }

        public string ChildAbbreviatedName { get; set; }

        public string ChildPersonalName { get; set; }

        public string Gender { get; set; }

        public string BirthDate { get; set; }

        public bool BirthDateKnownFlag { get; set; }

        public bool CspGraduateFlag { get; set; }

        public string CspEnrollDate { get; set; }

        public string CspProjectKey { get; set; }

        public string ChildCaseStudyDate { get; set; }

        public string CaseStudyChildKey { get; set; }

        public string BasicChildInternalComment { get; set; }

        public bool OverAgeAllowed { get; set; }

        public List<string> ChristianActivities { get; set; }

        public string OtherChristianActivities { get; set; }

        public List<string> FamilyDuties { get; set; }

        public string OtherFamilyDuties { get; set; }

        public List<string> HobbiesAndSports { get; set; }

        public string OtherHobbies { get; set; }

        public List<string> HealthConditions { get; set; }

        public string OtherHealthConditions { get; set; }

        public ChildCaseStudySchoolingRest Schooling { get; set; }

        public List<string> Guardians { get; set; }

        public ChildCaseStudyNaturalParents NaturalParents { get; set; }

        public ChildCaseStudyEmployment Employment { get; set; }

        public ChildCaseStudyFamilySize FamilySize { get; set; }

        public string ChildCaseStudyLastModifiedDate { get; set; }
    }
}