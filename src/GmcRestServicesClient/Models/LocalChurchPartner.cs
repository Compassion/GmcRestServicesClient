using System;

namespace GmcRestServicesClient.Models
{
    public class LocalChurchPartner
    {
        /// <summary>
        /// Same value as input
        /// </summary>
        public int LocalChurchPartnerID { get; set; }

        /// <summary>
        /// Uniquely identifies the Party who is playing the role of implementor
        /// </summary>
        public string PartyID { get; set; }
        
        /// <summary>
        /// Name of the local church partner
        /// </summary>
        public string OrganizationName { get; set; }
        
        /// <summary>
        /// Date the local church partner affiliation began or will begin
        /// </summary>
        public DateTime StartDate { get; set; }
        
        /// <summary>
        /// Date the local church partner affiliation ended or will end
        /// </summary>
        public DateTime? StopDate { get; set; }
        
        /// <summary>
        /// Flag indicating if the local church partner has electiricty in the building
        /// </summary>
        public bool ChurchHasElectricity { get; set; }
        
        /// <summary>
        /// Flag indicating if the local church partner has a phone 
        /// </summary>
        public bool ChurchHasPhone { get; set; }
        
        /// <summary>
        /// Flag indicating if the local church partner has a phone 
        /// </summary>
        public bool ChurchOwnsBuilding { get; set; }
        
        /// <summary>
        /// Text describing what language(s) are used during a church service 
        /// </summary>
        public string ChurchServiceLanguages { get; set; }
        
        /// <summary>
        /// Community ID where the local church partner is located 
        /// </summary>
        public int CommunityID { get; set; }
        
        /// <summary>
        /// Email address of the contact person
        /// </summary>
        public string ContactEmailAddress { get; set; }
        
        /// <summary>
        /// Name of person to contact at the local church partner
        /// </summary>
        public string ContactPersonName { get; set; }
        
        /// <summary>
        /// Phone number of the contact person 
        /// </summary>
        public string ContactPhoneNumber { get; set; }
        
        /// <summary>
        /// Title of the contact person
        /// </summary>
        public string ContactTitle { get; set; }
        
        /// <summary>
        /// Country Id where the local church partner is located 
        /// </summary>
        public string CountryID { get; set; }
        
        /// <summary>
        /// Fax number of the local church partner 
        /// </summary>
        public string FaxNumber { get; set; }
        
        /// <summary>
        /// Name to use to designate the recipient of money for the local church partner
        /// </summary>
        public string FundPayableName { get; set; }
        
        /// <summary>
        /// GPS Latitude of the location of the local church partner – High Precision
        /// </summary>
        public string GpsCoordinateLatitudeHighPrecision { get; set; }

        /// <summary>
        /// GPS Latitude of the location of the local church partner – Low Precision
        /// </summary>
        public string GpsCoordinateLatitudeLowPrecision { get; set; }

        /// <summary>
        /// GPS Longitude of the location of the local church partner – High Precision
        /// </summary>
        public string GpsCoordinateLongitudeHighPrecision { get; set; }

        /// <summary>
        /// GPS Longitude of the location of the local church partner – Low Precision
        /// </summary>
        public string GpsCoordinateLongitudeLowPrecision { get; set; }
        
        /// <summary>
        /// Code indicating if the local church partner is in an HIV/Aids infected area
        /// </summary>
        public string HivCategory { get; set; }
        
        /// <summary>
        /// Date of last review for the local church partner 
        /// </summary>
        public DateTime LastReviewDate { get; set; }

        /// <summary>
        /// Date the information was last updated 
        /// </summary>
        public DateTime LastUpdateDate { get; set; }
        
        /// <summary>
        /// Mailing address of local church 
        /// </summary>
        public string MailingAddressLine1 { get; set; }
        
        public string MailingAddressLine2 { get; set; }
        
        public string MailingAddressLine3 { get; set; }
        
        public string MailingAddressLine4 { get; set; }
        
        /// <summary>
        /// Month in which school begins
        /// </summary>
        public string MonthSchoolYearBegins { get; set; }
        
        /// <summary>
        /// Number of hours volunteers work in a month
        /// </summary>
        public string MonthlyVolunteerHours { get; set; }
        
        /// <summary>
        /// Number of employees paid by the local church partner
        /// </summary>
        public string PaidStaffCount { get; set; }
        
        /// <summary>
        /// The percentage of registered beneficiaries who are not in school
        /// </summary>
        public string PercentNotInSchool { get; set; }
        
        /// <summary>
        /// Reason more than 25% of the registered beneficiaries are not in school
        /// </summary>
        public string PercentNotInSchoolReason { get; set; }
        
        /// <summary>
        /// Percentage of registered beneficiaries who have completed elementary school
        /// </summary>
        public string PercentCompletingElementarySchool { get; set; }
        
        public string ElementaryCompletionStatus { get; set; }
        
        /// <summary>
        /// Percentage of registered beneficiaries who have completed secondary school
        /// </summary>
        public string PercentCompletingSecondarySchool { get; set; }
        
        public string SecondaryCompletionStatus { get; set; }
        
        /// <summary>
        /// Address of the physical location of the local church
        /// </summary>
        public string PhysicalAddressLine1 { get; set; }
        
        public string PhysicalAddressLine2 { get; set; }
        
        public string PhysicalAddressLine3 { get; set; }
        
        public string PhysicalAddressLine4 { get; set; }
        
        /// <summary>
        /// Denomination in the local country which the church is affiliated
        /// </summary>
        public string CountryDenomination { get; set; }
        
        /// <summary>
        /// Western denomination which the church’s local denomination is affiliated 
        /// </summary>
        public string WesternDenomination { get; set; }
    }
}