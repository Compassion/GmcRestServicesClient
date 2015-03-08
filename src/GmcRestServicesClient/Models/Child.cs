using System;

namespace GmcRestServicesClient.Models
{
    public class Child
    {
        public int ChildID { get; set; }

        public string ChildKey { get; set; }

        public string ChildName { get; set; }

        public string ChildAbbreviatedName { get; set; }

        public string ChildPersonalName { get; set; }

        public string Gender { get; set; }

        public DateTime? BirthDate { get; set; }

        public int Age { get; set; }

        public bool BirthDateKnownFlag { get; set; }
        
        public DateTime StartDate { get; set; }

        public DateTime FieldStartDate { get; set; }
        
        public DateTime LastCaseStudyDate { get; set; }

        public DateTime LastCaseStudyModifiedDate { get; set; }
        
        public bool OverAgeFlag { get; set; }

        public bool SiblingFlag { get; set; }
        
        public bool OrphanFlag { get; set; }

        public bool HandicappedFlag { get; set; }

        public bool ChildAttendingSchool { get; set; }

        public string USSchoolEquivalent { get; set; }
        
        public string SchoolPerformance { get; set; }

        public DateTime? CDSPCompletionDate { get; set; }

        public bool CSPGraduateFlag { get; set; }

        public DateTime? CSPEnrollDate { get; set; }

        public string CSPProject { get; set; }

        public bool SponsorFlag { get; set; }
        
        public string ProgramStatus { get; set; }

        public DateTime? ParticipationStopDate { get; set; }

        public DateTime? BeginWaitTime { get; set; }

        public ChildBiography ChildBiography { get; set; }

        public int ParticipationID { get; set; }
    }
}
