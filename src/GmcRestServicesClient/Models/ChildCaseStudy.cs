using System;
using System.Collections.Generic;

namespace GmcRestServicesClient.Models
{
    public class ChildCaseStudy
    {
        /// <summary>
        /// Child identifier
        /// </summary>
        public int ChildID { get; set; }

        /// <summary>
        /// Same value as input
        /// </summary>
        public string ChildKey { get; set; }

        /// <summary>
        /// Name of the child
        /// </summary>
        public string ChildName { get; set; }

        /// <summary>
        /// Child name abbreviated to 30 characters
        /// </summary>
        public string ChildAbbreviatedName { get; set; }

        /// <summary>
        /// First name or nickname that is used to address the child
        /// </summary>
        public string ChildPersonalName { get; set; }

        /// <summary>
        /// Child's gender
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Child's birth date
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Flag indicating if child actual birth date is known
        /// </summary>
        public bool BirthDateKnownFlag { get; set; }

        /// <summary>
        /// Flag designating a child as a CSP graduate
        /// </summary>
        public bool CspGraduateFlag { get; set; }

        /// <summary>
        /// Date this child was enrolled into Compassion's Child Survival Program
        /// </summary>
        public DateTime? CspEnrollDate { get; set; }

        /// <summary>
        /// Child Survival Program code
        /// </summary>
        public string CspProjectKey { get; set; }

        public DateTime ChildCaseStudyDate { get; set; }

        public string CaseStudyChildKey { get; set; }

        public string BasicChildInternalComment { get; set; }

        /// <summary>
        /// Flag indicating if the child is allowed to continue in the program beyond the maximum age
        /// </summary>
        public bool OverAgeAllowed { get; set; }

        /// <summary>
        /// <para>Section containing Christian activites the child participates in.</para>
        /// <para>List of activity values that the child can be engaged in: </para>
        /// <list type="bullet">
        ///   <item><description>Sunday School/Church</description></item> 
        ///   <item><description>Bible Class</description></item>
        ///   <item><description>Camp</description></item>
        ///   <item><description>Youth Group</description></item>
        ///   <item><description>Vacation Bible School Choir</description></item>
        /// </list>
        /// </summary>
        public List<string> ChristianActivities { get; set; }

        /// <summary>
        /// Other Christian activities the child is engaged in that are not included in ChristianActivities. This is free text.
        /// </summary>
        public string OtherChristianActivities { get; set; }

        /// <summary>
        /// <para>Section containing family duties the child participates in.</para>
        /// <para>List of duty values that the child can participate in:</para> 
        /// <list type="bullet">
        ///   <item><description>Washing Clothes</description></item>
        ///   <item><description>Making Beds</description></item>
        ///   <item><description>Cleaning</description></item>
        ///   <item><description>Carries Water</description></item>
        ///   <item><description>Kitchen Help</description></item>
        ///   <item><description>Animal Care</description></item>
        ///   <item><description>Running Errands</description></item>
        ///   <item><description>Child Care</description></item>
        ///   <item><description>Buying/Selling in Market</description></item>
        ///   <item><description>Gathers Firewood</description></item>
        ///   <item><description>Gardening/Farming</description></item>
        ///   <item><description>Sewing</description></item>
        ///   <item><description>Teaching Others</description></item>
        /// </list>
        /// </summary>
        public List<string> FamilyDuties { get; set; }

        /// <summary>
        /// Other family duties that are not included in FamilyDuties. This is free text.
        /// </summary>
        public string OtherFamilyDuties { get; set; }

        /// <summary>
        /// <para>Section containing hobbies and sports the child participates in.</para>
        /// <para>List of hobbies or sports values that a child can participate in:</para>
        /// <list type="bullet">
        ///   <item><description>Art/Drawing</description></item>
        ///   <item><description>Baseball</description></item>
        ///   <item><description>Basketball</description></item>
        ///   <item><description>Bicycling</description></item>
        ///   <item><description>Cars</description></item>
        ///   <item><description>Dolls</description></item>
        ///   <item><description>Group Games</description></item>
        ///   <item><description>Hide and Seek</description></item>
        ///   <item><description>Jacks</description></item>
        ///   <item><description>Jump Rope</description></item>
        ///   <item><description>Listening to Music</description></item>
        ///   <item><description>Marbles</description></item>
        ///   <item><description>Musical Instrument</description></item>
        ///   <item><description>Other Ball Games</description></item>
        ///   <item><description>Other Sports Or Hobbies</description></item>
        ///   <item><description>Ping Pong</description></item>
        ///   <item><description>Play House</description></item>
        ///   <item><description>Reading</description></item>
        ///   <item><description>Rolling a hoop</description></item>
        ///   <item><description>Running</description></item>
        ///   <item><description>Singing</description></item>
        ///   <item><description>Soccer/Footbal</description></item>
        ///   <item><description>Story Telling</description></item>
        ///   <item><description>Swimming</description></item>
        ///   <item><description>Volleyball</description></item>
        ///   <item><description>Walking</description></item>
        ///   <item><description>MusicalInstrument: followed by free text</description></item>
        /// </list>
        /// </summary>
        public List<string> HobbiesAndSports { get; set; }

        /// <summary>
        /// Other hobbies or sports the child participates in. This is free text.
        /// </summary>
        public string OtherHobbies { get; set; }

        /// <summary>
        /// <para>Section containing health condtions of the child.</para>
        /// <para>List of health condition values:</para>
        /// <list type="bullet">
        ///   <item><description>Epilepsy</description></item>
        ///   <item><description>Asthma</description></item>
        ///   <item><description>Polio</description></item>
        ///   <item><description>Developmentally Disabled</description></item>
        ///   <item><description>Speech: (values: Defective, Mute)</description></item>
        ///   <item><description>Hearing Left Ear: (values: Defective, Deaf)</description></item>
        ///   <item><description>Hearing Right Ear: (values: Defective, Deaf)</description></item>
        ///   <item><description>Sight Left Eye: (values: Defective, Blind)</description></item>
        ///   <item><description>Sight Right Eye: (values: Defective, Blind)</description></item>
        ///   <item><description>Regular Medical Treatmnt</description></item>
        ///   <item><description>Regular Medication</description></item>
        ///   <item><description>None</description></item>
        /// </list>
        /// <para>The following can have a value of (Crippled/Birth, Crippled/Disease, Crippled/Injury):</para>
        /// <list type="bullet">
        ///   <item><description>Left Leg due to: </description></item>
        ///   <item><description>Right Leg due to: </description></item>
        ///   <item><description>Left Foot due to: </description></item>
        ///   <item><description>Right Foot due to:</description></item>
        ///   <item><description>Left Arm due to: </description></item>
        ///   <item><description>Right Arm due to: </description></item>
        ///   <item><description>Left Hand due to: </description></item>
        ///   <item><description>Right Hand due to: </description></item>
        ///   <item><description>Spine due to: </description></item>
        /// </list>
        /// </summary>
        public List<string> HealthConditions { get; set; }

        /// <summary>
        /// Other health conditions the child has that are not listed above. This is free text.
        /// </summary>
        public string OtherHealthConditions { get; set; }

        /// <summary>
        /// Section containing schooling information of the child
        /// </summary>
        public ChildCaseStudySchooling Schooling { get; set; }

        /// <summary>
        /// <para>Section describing the child's guardians.</para>
        /// <para>List of child guardian values:</para>
        /// <list type="bullet">
        ///   <item><description>Mother</description></item>
        ///   <item><description>Father</description></item>
        ///   <item><description>Uncle</description></item>
        ///   <item><description>Aunt</description></item>
        ///   <item><description>Grandfather</description></item>
        ///   <item><description>Grandmother</description></item>
        ///   <item><description>Brother</description></item>
        ///   <item><description>Sister</description></item>
        ///   <item><description>Stepfather</description></item>
        ///   <item><description>Stepmother</description></item>
        ///   <item><description>Godfather</description></item>
        ///   <item><description>Godmother</description></item>
        ///   <item><description>Friends</description></item>
        ///   <item><description>Institutional Worker</description></item>
        ///   <item><description>Foster Parents</description></item>
        ///   <item><description>Other Relatives</description></item>
        /// </list>
        /// </summary>
        public List<string> Guardians { get; set; }

        /// <summary>
        /// Section describing the child's natural parents
        /// </summary>
        public ChildCaseStudyNaturalParents NaturalParents { get; set; }

        /// <summary>
        /// Section describing parents or guardians employment
        /// </summary>
        public ChildCaseStudyEmployment Employment { get; set; }

        /// <summary>
        /// Section describing family size the child lives in
        /// </summary>
        public ChildCaseStudyFamilySize FamilySize { get; set; }

        /// <summary>
        /// Last date Child Case Study was modified 
        /// </summary>
        public DateTime ChildCaseStudyLastModifiedDate { get; set; }
    }

    public class ChildCaseStudySchooling
    {
        public bool ChildAttendingSchool { get; set; }

        /// <summary>
        /// This is free text.
        /// </summary>
        public string ReasonNotAttending { get; set; }

        public string PreSchoolLevel { get; set; }

        public string KindergartenLevel { get; set; }

        public string PrimarySchoolLevel { get; set; }

        public string MiddleSchoolLevel { get; set; }

        public string HighSchoolLevel { get; set; }

        /// <summary>
        /// <para>Values can be:</para>
        /// <list type="bullet">
        ///   <item><description>blank</description></item>
        ///   <item><description>1</description></item>
        ///   <item><description>2</description></item>
        ///   <item><description>3</description></item>
        ///   <item><description>4</description></item>
        ///   <item><description>5</description></item>
        ///   <item><description>6</description></item>
        ///   <item><description>7</description></item>
        ///   <item><description>8</description></item>
        ///   <item><description>9</description></item>
        ///   <item><description>10</description></item>
        ///   <item><description>11</description></item>
        ///   <item><description>12</description></item>
        ///   <item><description>13</description></item>
        ///   <item><description>14</description></item>
        ///   <item><description>K (Note-this is Kindergarten)</description></item>
        ///   <item><description>P (Note-this is Primary)</description></item>
        ///   <item><description>PK (Note-this is pre-Kindergarten)</description></item>
        /// </list>
        /// </summary>
        public string UsSchoolEquivalent { get; set; }

        public string VocationalSchoolLevel { get; set; }

        /// <summary>
        /// This is free text
        /// </summary>
        public string VocationalCourseOfStudy { get; set; }

        public string ApprenticeshipLevel { get; set; }

        /// <summary>
        /// This is free text
        /// </summary>
        public string ApprenticeshipCourseOfStudy { get; set; }

        public string CollegeOrUniversityLevel { get; set; }

        public string CollegeCourseOfStudy { get; set; }

        public string OtherSchoolLevel { get; set; }

        /// <summary>
        /// This is free text
        /// </summary>
        public string OtherCourseOfStudy { get; set; }

        /// <summary>
        /// <para>Values  can be:</para>
        /// <list type="bullet">
        ///   <item><description>Below Average</description></item>
        ///   <item><description>Average</description></item>
        ///   <item><description>Above Average</description></item>
        /// </list>
        /// </summary>
        public string SchoolPerformance { get; set; }

        /// <summary>
        /// This is free text
        /// </summary>
        public string ChildsBestSubject { get; set; }

        public DateTime? FutureHighSchoolDate { get; set; }

        /// <summary>
        /// This is free text
        /// </summary>
        public string FutureHighSchoolCourseOfStudy { get; set; }

        public DateTime? FutureUniversityDate { get; set; }

        /// <summary>
        /// This is free text
        /// </summary>
        public string FutureUniversityCourseOfStudy { get; set; }

        public DateTime? FutureBibleSchoolDate { get; set; }

        /// <summary>
        /// This is free text
        /// </summary>
        public string FutureBibleSchoolCourseOfStudy { get; set; }

        public DateTime? FutureVocationalDate { get; set; }

        /// <summary>
        /// This is free text
        /// </summary>
        public string FutureVocationalCourseOfStudy { get; set; }

        public string FutureOtherSchoolDescription { get; set; }

        public DateTime? FutureOtherSchoolDate { get; set; }

        /// <summary>
        /// This is free text
        /// </summary>
        public string FutureOtherSchoolCourseOfStudy { get; set; }

        /// <summary>
        /// Date the child is expected to complete the Ministry Program.
        /// </summary>
        public DateTime PlannedCompletionDate { get; set; }
    }

    public class ChildCaseStudyNaturalParents
    {
        public bool NaturalParentsTogether { get; set; }

        /// <summary>
        /// This is free text.
        /// </summary>
        public string MaritalStatusOfParents { get; set; }

        public bool FatherAlive { get; set; }

        public bool FatherLivingWithChild { get; set; }

        public bool FatherSupportingChild { get; set; }

        public bool MotherAlive { get; set; }

        public bool MotherLivingWithChild { get; set; }

        public bool MotherSupportingChild { get; set; }

        public bool FatherHandicapped { get; set; }

        /// <summary>
        /// Describes father's handicap
        /// </summary>
        public string FathersHandicap { get; set; }

        public bool MotherHandicapped { get; set; }

        /// <summary>
        /// Describes mother's handicap
        /// </summary>
        public string MothersHandicap { get; set; }

        public bool FatherChronicallyIll { get; set; }

        /// <summary>
        /// Describes father's illness
        /// </summary>
        public string FathersChronicIllness { get; set; }

        public bool MotherChronicallyIll { get; set; }

        /// <summary>
        /// Describes mother's illness
        /// </summary>
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

        /// <summary>
        ///  Type of laborer 
        /// </summary>
        public string FatherOrMaleGuardianIsALaborer { get; set; }

        /// <summary>
        ///  Other type of employment 
        /// </summary>
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

        /// <summary>
        ///  Type of laborer 
        /// </summary>
        public string MotherOrFemaleGuardianIsALaborer { get; set; }

        /// <summary>
        ///  Other type of employment 
        /// </summary>
        public string MotherOrFemaleGuardianOtherEmployment { get; set; }
    }

    public class ChildCaseStudyFamilySize
    {
        public string TotalFamilyFemalesUnder18 { get; set; }

        public string TotalFamilyMalesUnder18 { get; set; }

        /// <summary>
        ///  Other sibling in Compassion program 
        /// </summary>
        public string FirstBrotherOrSister { get; set; }

        /// <summary>
        ///  Other sibling in Compassion program 
        /// </summary>
        public string SecondBrotherOrSister { get; set; }
    }
}