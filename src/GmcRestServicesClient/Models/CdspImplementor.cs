using System;

namespace GmcRestServicesClient.Models
{
    public class CdspImplementor
    {
        /// <summary>
        /// Value of the CDSP Implementor Id associated with the input parameter
        /// </summary>
        public int CdspImplementorID { get; set; }

        /// <summary>
        /// Value of the Party Id associated with the input parameter
        /// </summary>
	    public string PartyID { get; set; }

        /// <summary>
        /// Does not return a value
        /// </summary>
	    public string CdspImplementorKey { get; set; }

        /// <summary>
        /// Same value as input
        /// </summary>
	    public string CdspImplementorKeyLegacy { get; set; }

        /// <summary>
        /// Name of the CDSP Implementor
        /// </summary>
	    public string Name { get; set; }

        /// <summary>
        /// Date the partnership began
        /// </summary>
	    public DateTime StartDate { get; set; }

        /// <summary>
        /// Date the partnership ended
        /// </summary>
	    public DateTime? StopDate { get; set; }

        /// <summary>
        ///  Date the implementor information was first entered in Compassion system 
        /// </summary>
	    public DateTime FirstEnteredDate { get; set; }

        /// <summary>
        ///  Date the implementor information was first received or an update was received  
        /// </summary>
	    public DateTime LastUpdateDate { get; set; }

        /// <summary>
        ///  Date the annual information update was received  
        /// </summary>
        public DateTime LastReviewDate { get; set; }

        /// <summary>
        /// <para>One character status field indicating if the project is (A)ctive, on (P)hase-out, or (T)erminated. There is not a suspended status.</para>
        /// <para>One of the letters in parentheses are returned in the response.</para>
        /// </summary>
	    public string Status { get; set; }

        /// <summary>
        /// Status exposed to the external clients 
        /// </summary>
	    public string ExternalStatus { get; set; }

        /// <summary>
        /// Date the program status became effective  
        /// </summary>
	    public DateTime StatusDate { get; set; }

        /// <summary>
        /// Description of why a program status date was changed.   e.g. mm-dd-yy  SUSPENSION: LINKED CSP EC-Cxx ALSO SUSPENDED. 
        /// </summary>
	    public string StatusComment { get; set; }

        /// <summary>
        /// Date status was recorded in Compassion system  
        /// </summary>
	    public DateTime? DateStatusDateEntered { get; set; }

        /// <summary>
        /// Description of the project  
        /// </summary>
	    public string Description { get; set; }

        /// <summary>
        /// Project activities specifically for CDSP children who do not attend school  
        /// </summary>
	    public string ActivitiesForNonSchoolChildren { get; set; }

        /// <summary>
        /// Project activities targeted to CDSP child cognitive and/or vocational development  
        /// </summary>
	    public string CognitiveOrVocationalActivities { get; set; }

        /// <summary>
        /// Project activities not targeted to a particular development activity  
        /// </summary>
	    public string OtherActivities { get; set; }

        /// <summary>
        /// Project activities targeted to parent and family development 
        /// </summary>
	    public string ParentOrFamilyActivities { get; set; }

        /// <summary>
        /// Project activities targeted to CDSP child physical development 
        /// </summary>
	    public string PhysicalOrHealthActivities { get; set; }

        /// <summary>
        /// Project activities targeted to CDSP child social/emotional development  
        /// </summary>
	    public string SocialOrEmotionalActivities { get; set; }

        /// <summary>
        /// Project activities targeted to CDSP child spiritual development  
        /// </summary>
	    public string SpiritualActivities { get; set; }

        /// <summary>
        /// Annual cost for a child to attend school in the community where the CDSP Implementor is located  
        /// </summary>
	    public decimal AnnualSchoolCostInDollars { get; set; }

        /// <summary>
        /// Flag indicating if gifts may be disbursed to the CDSP Implementor or to the CDSP child
        /// </summary>
	    public bool DisburseGifts { get; set; }

        /// <summary>
        /// Flag indicating if funds, not including gifts can be disbursed to the CDSP Implementor or CDSP children
        /// </summary>
	    public bool DisburseFunds { get; set; }

        /// <summary>
        /// Flag indicating if unsponsored funds can be disbursed to the CDSP Implementor or CDSP child  
        /// </summary>
	    public bool DisburseUnsponsoredFunds { get; set; }

        /// <summary>
        /// Flag indicating if commitmentscan be created  
        /// </summary>
	    public bool NewSponsorshipsAllowed { get; set; }

        /// <summary>
        /// Flag indicating if the quota may be continued
        /// </summary>
	    public bool AdditionalQuotaAllowed { get; set; }

        /// <summary>
        /// Email address of the contact person
        /// </summary>
	    public string ContactEmailAddress { get; set; }

        /// <summary>
        /// Name of person to contact 
        /// </summary>
	    public string ContactPersonName { get; set; }

        /// <summary>
        /// Phone number of the contact person 
        /// </summary>
	    public string ContactPhoneNumber { get; set; }

        /// <summary>
        /// Job title of the contact person
        /// </summary>
	    public string ContactTitle { get; set; }

        /// <summary>
        /// Fax number 
        /// </summary>
	    public string FaxNumber { get; set; }

        /// <summary>
        /// GPS Latitude of the location of the CDSP Implementor – High Precision 
        /// </summary>
	    public string GpsCoordinateLatitudeHighPrecision { get; set; }

        /// <summary>
        /// GPS Latitude of the location of the CDSP Implementor – Low Precision
        /// </summary>
	    public string GpsCoordinateLatitudeLowPrecision { get; set; }

        /// <summary>
        /// GPS Longitude of the location of the CDSP Implementor – High Precision
        /// </summary>
	    public string GpsCoordinateLongitudeHighPrecision { get; set; }

        /// <summary>
        /// GPS Longitude of the location of the CDSP Implementor – Low Precision
        /// </summary>
	    public string GpsCoordinateLongitudeLowPrecision { get; set; }

        /// <summary>
        /// Mailing address 
        /// </summary>
	    public string MailingAddressLine1 { get; set; }

	    public string MailingAddressLine2 { get; set; }

	    public string MailingAddressLine3 { get; set; }

	    public string MailingAddressLine4 { get; set; }

        /// <summary>
        /// Address of the physical location
        /// </summary>
	    public string PhysicalAddressLine1 { get; set; }

	    public string PhysicalAddressLine2 { get; set; }

	    public string PhysicalAddressLine3 { get; set; }

	    public string PhysicalAddressLine4 { get; set; }

	    public string LinkedProjectKey { get; set; }

	    public string LinkedProjectName { get; set; }

	    public string ActivityHoursPerWeek { get; set; }
	    
        public DateTime DescriptionModificationDate { get; set; }

        /// <summary>
        /// Date record was created or modified
        /// </summary>
        public DateTime LastModifiedDate { get; set; }
    }
}