using System;

namespace GmcRestServicesClient.Models
{
    public class LocalChurchPartner
    {
        public int LocalChurchPartnerID { get; set; }

        public string PartyID { get; set; }
        
        public string OrganizationName { get; set; }
        
        public DateTime StartDate { get; set; }
        
        public DateTime? StopDate { get; set; }
        
        public bool ChurchHasElectricity { get; set; }
        
        public bool ChurchHasPhone { get; set; }
        
        public bool ChurchOwnsBuilding { get; set; }
        
        public string ChurchServiceLanguages { get; set; }
        
        public int CommunityID { get; set; }
        
        public string ContactEmailAddress { get; set; }
        
        public string ContactPersonName { get; set; }
        
        public string ContactPhoneNumber { get; set; }
        
        public string ContactTitle { get; set; }
        
        public string CountryID { get; set; }
        
        public string FaxNumber { get; set; }
        
        public string FundPayableName { get; set; }
        
        public string GpsCoordinateLatitudeHighPrecision { get; set; }

        public string GpsCoordinateLatitudeLowPrecision { get; set; }

        public string GpsCoordinateLongitudeHighPrecision { get; set; }

        public string GpsCoordinateLongitudeLowPrecision { get; set; }
        
        public string HivCategory { get; set; }
        
        public DateTime LastReviewDate { get; set; }

        public DateTime LastUpdateDate { get; set; }
        
        public string MailingAddressLine1 { get; set; }
        
        public string MailingAddressLine2 { get; set; }
        
        public string MailingAddressLine3 { get; set; }
        
        public string MailingAddressLine4 { get; set; }
        
        public string MonthSchoolYearBegins { get; set; }
        
        public string MonthlyVolunteerHours { get; set; }
        
        public string PaidStaffCount { get; set; }
        
        public string PercentNotInSchool { get; set; }
        
        public string PercentNotInSchoolReason { get; set; }
        
        public string PercentCompletingElementarySchool { get; set; }
        
        public string ElementaryCompletionStatus { get; set; }
        
        public string PercentCompletingSecondarySchool { get; set; }
        
        public string SecondaryCompletionStatus { get; set; }
        
        public string PhysicalAddressLine1 { get; set; }
        
        public string PhysicalAddressLine2 { get; set; }
        
        public string PhysicalAddressLine3 { get; set; }
        
        public string PhysicalAddressLine4 { get; set; }
        
        public string CountryDenomination { get; set; }
        
        public string WesternDenomination { get; set; }
    }
}