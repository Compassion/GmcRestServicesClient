using System;
using System.Collections.Generic;

namespace GmcRestServicesClient.Models
{
    public class ChildCaseStudy
    {
        public int ChildID { get; set; }

        public string ChildKey { get; set; }

        public string ChildName { get; set; }

        public string ChildAbbreviatedName { get; set; }

        public string ChildPersonalName { get; set; }

        public string Gender { get; set; }

        public DateTime? BirthDate { get; set; }

        public bool BirthDateKnownFlag { get; set; }

        public bool CspGraduateFlag { get; set; }

        public DateTime? CspEnrollDate { get; set; }

        public string CspProjectKey { get; set; }

        public DateTime ChildCaseStudyDate { get; set; }

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

        public ChildCaseStudySchooling Schooling { get; set; }

        public List<string> Guardians { get; set; }

        public ChildCaseStudyNaturalParents NaturalParents { get; set; }

        public ChildCaseStudyEmployment Employment { get; set; }

        public ChildCaseStudyFamilySize FamilySize { get; set; }

        public DateTime ChildCaseStudyLastModifiedDate { get; set; }
    }

    public class ChildCaseStudySchooling
    {
        public bool ChildAttendingSchool { get; set; }

        public string ReasonNotAttending { get; set; }

        public string PreSchoolLevel { get; set; }

        public string KindergartenLevel { get; set; }

        public string PrimarySchoolLevel { get; set; }

        public string MiddleSchoolLevel { get; set; }

        public string HighSchoolLevel { get; set; }

        public string UsSchoolEquivalent { get; set; }

        public string VocationalSchoolLevel { get; set; }

        public string VocationalCourseOfStudy { get; set; }

        public string ApprenticeshipLevel { get; set; }

        public string ApprenticeshipCourseOfStudy { get; set; }

        public string CollegeOrUniversityLevel { get; set; }

        public string CollegeCourseOfStudy { get; set; }

        public string OtherSchoolLevel { get; set; }

        public string OtherCourseOfStudy { get; set; }

        public string SchoolPerformance { get; set; }

        public string ChildsBestSubject { get; set; }

        public DateTime? FutureHighSchoolDate { get; set; }

        public string FutureHighSchoolCourseOfStudy { get; set; }

        public DateTime? FutureUniversityDate { get; set; }

        public string FutureUniversityCourseOfStudy { get; set; }

        public DateTime? FutureBibleSchoolDate { get; set; }

        public string FutureBibleSchoolCourseOfStudy { get; set; }

        public DateTime? FutureVocationalDate { get; set; }

        public string FutureVocationalCourseOfStudy { get; set; }

        public string FutureOtherSchoolDescription { get; set; }

        public DateTime? FutureOtherSchoolDate { get; set; }

        public string FutureOtherSchoolCourseOfStudy { get; set; }

        public DateTime PlannedCompletionDate { get; set; }
    }

    public class ChildCaseStudyNaturalParents
    {
        public bool NaturalParentsTogether { get; set; }

        public string MaritalStatusOfParents { get; set; }

        public bool FatherAlive { get; set; }

        public bool FatherLivingWithChild { get; set; }

        public bool FatherSupportingChild { get; set; }

        public bool MotherAlive { get; set; }

        public bool MotherLivingWithChild { get; set; }

        public bool MotherSupportingChild { get; set; }

        public bool FatherHandicapped { get; set; }

        public string FathersHandicap { get; set; }

        public bool MotherHandicapped { get; set; }

        public string MothersHandicap { get; set; }

        public bool FatherChronicallyIll { get; set; }

        public string FathersChronicIllness { get; set; }

        public bool MotherChronicallyIll { get; set; }

        public string MothersChronicIllness { get; set; }

        public bool FatherMentallyIll { get; set; }

        public bool MotherMentallyIll { get; set; }

        public bool FatherInPrison { get; set; }

        public bool MotherInPrison { get; set; }
    }

    public class ChildCaseStudyEmployment
    {
        public bool FatherOrMaleGuardianIsEmployed { get; set; }

        public bool FatherOrMaleGuardianIsAtTimesEmployed { get; set; }

        public bool FatherOrMaleGuardianIsUnemployed { get; set; }

        public bool NoFatherOrMaleGuardian { get; set; }

        public bool FatherOrMaleGuardianIsAFarmer { get; set; }

        public bool FatherOrMaleGuardianSellsInMarket { get; set; }

        public bool FatherOrMaleGuardianIsAChurchWorker { get; set; }

        public bool FatherOrMaleGuardianIsAProjectWorker { get; set; }

        public bool FatherOrMaleGuardianIsATeacher { get; set; }

        public string FatherOrMaleGuardianIsALaborer { get; set; }

        public string FatherOrMaleGuardianOtherEmployment { get; set; }

        public bool MotherOrFemaleGuardianIsEmployed { get; set; }

        public bool MotherOrFemaleGuardianIsAtTimesEmployed { get; set; }

        public bool MotherOrFemaleGuardianIsUnemployed { get; set; }

        public bool NoMotherOrFemaleGuardian { get; set; }

        public bool MotherOrFemaleGuardianIsAFarmer { get; set; }

        public bool MotherOrFemaleGuardianSellsInMarket { get; set; }

        public bool MotherOrFemaleGuardianIsAChurchWorker { get; set; }

        public bool MotherOrFemaleGuardianIsAProjectWorker { get; set; }

        public bool MotherOrFemaleGuardianIsATeacher { get; set; }

        public string MotherOrFemaleGuardianIsALaborer { get; set; }

        public string MotherOrFemaleGuardianOtherEmployment { get; set; }
    }

    public class ChildCaseStudyFamilySize
    {
        public string TotalFamilyFemalesUnder18 { get; set; }

        public string TotalFamilyMalesUnder18 { get; set; }

        public string FirstBrotherOrSister { get; set; }

        public string SecondBrotherOrSister { get; set; }
    }
}