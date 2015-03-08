namespace GmcRestServicesClient.Models.Rest
{
    internal class ChildRest
    {
        public int ChildID { get; set; }

        public string ChildKey { get; set; }

        public string ChildName { get; set; }

        public string ChildAbbreviatedName { get; set; }

        public string ChildPersonalName { get; set; }

        public string Gender { get; set; }

        public string BirthDate { get; set; }

        public int Age { get; set; }

        public bool BirthDateKnownFlag { get; set; }

        public string StartDate { get; set; }

        public string FieldStartDate { get; set; }

        public string LastCaseStudyDate { get; set; }

        public string LastCaseStudyModifiedDate { get; set; }
        
        public bool OverAgeFlag { get; set; }

        public bool SiblingFlag { get; set; }
        
        public bool OrphanFlag { get; set; }

        public bool HandicappedFlag { get; set; }

        public bool ChildAttendingSchool { get; set; }

        public string USSchoolEquivalent { get; set; }
        
        public string SchoolPerformance { get; set; }

        public string CDSPCompletionDate { get; set; }

        public bool CSPGraduateFlag { get; set; }

        public string CSPEnrollDate { get; set; }

        public string CSPProject { get; set; }

        public bool SponsorFlag { get; set; }
        
        public string ProgramStatus { get; set; }

        public string ParticipationStopDate { get; set; }

        public string BeginWaitTime { get; set; }

        public ChildBiography ChildBiography { get; set; }

        public int ParticipationID { get; set; }
    }
}