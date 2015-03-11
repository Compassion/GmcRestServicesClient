using System;

namespace GmcRestServicesClient.Models
{
    public class Child
    {
        public int ChildID { get; set; }

        /// <summary>
        /// Code assigned by Compassion International when the child is registered in the Child Sponsorship Program.
        /// </summary>
        public string ChildKey { get; set; }

        /// <summary>
        /// Name of the child.
        /// </summary>
        public string ChildName { get; set; }

        /// <summary>
        /// Child name abbreviated to 30 characters.
        /// </summary>
        public string ChildAbbreviatedName { get; set; }

        /// <summary>
        /// First name or nickname that is used to address the child.
        /// </summary>
        public string ChildPersonalName { get; set; }

        /// <summary>
        /// Child's gender.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Child's birth date.
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Child's age.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Flag indicating if child actual birth date is known.
        /// </summary>
        public bool BirthDateKnownFlag { get; set; }
        
        /// <summary>
        /// Date that the first set of data for the CDSP Child was entered into the Compassion system.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The first Registration Date of the CDSP Child. It is recorded as the first day of the month the registration occurred.
        /// </summary>
        public DateTime FieldStartDate { get; set; }
        
        /// <summary>
        /// Date the last case study was completed for the child.
        /// </summary>
        public DateTime LastCaseStudyDate { get; set; }

        /// <summary>
        /// Date a portion of the current case study was modified.
        /// </summary>
        public DateTime LastCaseStudyModifiedDate { get; set; }
        
        /// <summary>
        /// Flag indicating if the child is allowed to continue in the program beyond the maximum age.
        /// </summary>
        public bool OverAgeFlag { get; set; }

        /// <summary>
        /// Flag indicating if the child has brothers or sisters in the CDSP Program.
        /// </summary>
        public bool SiblingFlag { get; set; }
        
        /// <summary>
        /// Flag indicating if the child has brothers or sisters in the CDSP Program.
        /// </summary>
        public bool OrphanFlag { get; set; }

        /// <summary>
        /// Indicator identifying a child as handicapped.
        /// </summary>
        public bool HandicappedFlag { get; set; }

        /// <summary>
        /// Flag indicating if the child is attending school.
        /// </summary>
        public bool ChildAttendingSchool { get; set; }

        /// <summary>
        /// <para>Equivalent US school grade level child is in.</para>
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
        public string USSchoolEquivalent { get; set; }
        
        /// <summary>
        /// Performance of child in school - average, below average or above average.
        /// </summary>
        public string SchoolPerformance { get; set; }

        /// <summary>
        /// Date child is expected to complete the CDSP Program.
        /// </summary>
        public DateTime? CDSPCompletionDate { get; set; }

        /// <summary>
        /// Flag designating a beneficiary as being a CSP graduate.
        /// </summary>
        public bool CSPGraduateFlag { get; set; }

        public DateTime? CSPEnrollDate { get; set; }

        /// <summary>
        /// An Implementing Church Partner that is a CSP Implementor.
        /// </summary>
        public string CSPProject { get; set; }

        /// <summary>
        /// Flag indicating if the child is sponsored.
        /// </summary>
        public bool SponsorFlag { get; set; }
        
        /// <summary>
        /// One of three states of a project: active, phase out, or terminated.
        /// </summary>
        public string ProgramStatus { get; set; }

        /// <summary>
        /// The date and time when the participation ended with Compassion.
        /// </summary>
        public DateTime? ParticipationStopDate { get; set; }

        /// <summary>
        /// The date and time when the child first started waiting for sponsorship.
        /// </summary>
        public DateTime? BeginWaitTime { get; set; }

        public ChildBiography ChildBiography { get; set; }

        /// <summary>
        /// Id of the current participation
        /// </summary>
        public int ParticipationID { get; set; }
    }
}
