using System;

namespace GmcRestServicesClient.Models
{
    public class ChildExitDetails
    {
        /// <summary>
        /// Compassion-generated unique text identifier for the child
        /// </summary>
        public string ChildKey { get; set; }

        /// <summary>
        /// Full name of the child
        /// </summary>
	    public string ChildName { get; set; }

        /// <summary>
        /// Gender of the child
        /// </summary>
	    public string Gender { get; set; }

        /// <summary>
        /// Age of the child in years
        /// </summary>
        public string Age { get; set; }
	    
        /// <summary>
        /// Date on which the exit is final
        /// </summary>
        public DateTime ExitDate { get; set; }
	    
        /// <summary>
        /// The date when the child was last attending project activities
        /// </summary>
        public DateTime DateLastAttendedProject { get; set; }
	    
        /// <summary>
        /// Date on which the exit report is completed
        /// </summary>
        public DateTime ReportDate { get; set; }
	    
        public string ReasonForAged { get; set; }
	    
        /// <summary>
        /// Name of the person who facilitated the exit
        /// </summary>
        public string ExitFacilitator { get; set; }
	    
        /// <summary>
        /// Name of the country director or designated supervisor responsible to oversee the exit
        /// </summary>
        public string CountryDirectorOrDesignate { get; set; }
	    
        /// <summary>
        /// Indicates whether the child had been presented with the gospel 
        /// </summary>
        public bool PresentedWithGospel { get; set; }
	    
        /// <summary>
        /// Indicates whether the child has made a profession of faith 
        /// </summary>
        public bool ProfessesFaithInJesusChrist { get; set; }
	    
        /// <summary>
        /// Indicates whether the child made a profession of faith while part of the Compassion program
        /// </summary>
        public bool ProfessedFaithWhileRegistered { get; set; }
	    
        /// <summary>
        /// Narrative description of the spiritual life of the child
        /// </summary>
        public string FaithDescription { get; set; }
	    
        /// <summary>
        /// Indicates whether the child has completed primary school
        /// </summary>
        public bool CompletedPrimarySchool { get; set; }
	    
        /// <summary>
        /// Grade level completed by the child according to the US Grade Level system
        /// </summary>
        public string UsGradeEquivalentCompleted { get; set; }
	    
        /// <summary>
        /// The primary area of study of the educational program in which the child participated
        /// </summary>
        public string AreaOfStudy { get; set; }
	    
        /// <summary>
        /// Indicates whether the child received vocational training
        /// </summary>
        public bool ReceivedVocationalTraining { get; set; }
	    
        /// <summary>
        /// List of skills learned if the child received vocational training
        /// </summary>
        public string VocationalSkillsLearned { get; set; }
	    
        /// <summary>
        /// Indicates whether the child is free from diseases normally associated with poverty
        /// </summary>
        public bool FreeOfPovertyRelatedDisease { get; set; }
	    
        /// <summary>
        /// Description of the overall health of the child
        /// </summary>
        public string HealthDescription { get; set; }
	    
        /// <summary>
        /// Indicates whether the child has had any recent negative behavior toward others
        /// </summary>
        public bool AvoidedRecentNegativeSocialBehavior { get; set; }
	    
        /// <summary>
        /// Description of the social development of the child
        /// </summary>
        public string SocialBehaviorDescription { get; set; }
	    
        /// <summary>
        /// Narrative description of the situation which led to exit
        /// </summary>
        public string ExitDescription { get; set; }
	    
        /// <summary>
        /// Describes the steps taken to prevent the exit
        /// </summary>
        public string StepsToPreventExitDescription { get; set; }
	    
        /// <summary>
        /// Description of the child's future plans
        /// </summary>
        public string FuturePlansDescription { get; set; }
	    
        /// <summary>
        /// Description of child's new situation as well as how they benefitted from Compassion program
        /// </summary>
        public string ChildNewSituationDescription { get; set; }
	    
        /// <summary>
        /// Primary reason for exit from program
        /// </summary>
        public string ExitReason { get; set; }
	    
        /// <summary>
        /// Secondary reason for exit from program
        /// </summary>
        public string OtherExitReason { get; set; }
	    
        /// <summary>
        /// Indicates whether last letter has been completed and sent
        /// </summary>
        public bool LastChildLetterSent { get; set; }
        
        public string ReasonForRejection { get; set; }
    }
}