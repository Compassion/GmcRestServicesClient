using System;

namespace GmcRestServicesClient.Models
{
    public class CspImplementor
    {
        public int CspImplementorID { get; set; }
        
        public string PartyID { get; set; }
        
        public string CspImplementorKey { get; set; }
        
        public string CspImplementorKeyLegacy { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? StopDate { get; set; }

        public DateTime FirstEnteredDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public DateTime LastReviewDate { get; set; }

        public string Status { get; set; }

        public string ExternalStatus { get; set; }

        public DateTime StatusDate { get; set; }

        public string StatusComment { get; set; }

        public DateTime? DateStatusDateEntered { get; set; }

        public string Description { get; set; }

        public string CognitiveOrVocationalActivities { get; set; }

        public string OtherActivities { get; set; }

        public string ParentOrFamilyActivities { get; set; }

        public string PhysicalOrHealthActivities { get; set; }

        public string SocialOrEmotionalActivities { get; set; }

        public string SpiritualActivities { get; set; }

        public bool DisburseGifts { get; set; }

        public bool DisburseFunds { get; set; }

        public bool DisburseUnsponsoredFunds { get; set; }

        public bool NewSponsorshipsAllowed { get; set; }

        public bool AdditionalQuotaAllowed { get; set; }

        public string ContactEmailAddress { get; set; }

        public string ContactPersonName { get; set; }

        public string ContactPhoneNumber { get; set; }

        public string ContactTitle { get; set; }

        public string FaxNumber { get; set; }

        public string GpsCoordinateLatitudeHighPrecision { get; set; }

        public string GpsCoordinateLatitudeLowPrecision { get; set; }

        public string GpsCoordinateLongitudeHighPrecision { get; set; }

        public string GpsCoordinateLongitudeLowPrecision { get; set; }

        public string MailingAddressLine1 { get; set; }

        public string MailingAddressLine2 { get; set; }

        public string MailingAddressLine3 { get; set; }

        public string MailingAddressLine4 { get; set; }

        public string PhysicalAddressLine1 { get; set; }

        public string PhysicalAddressLine2 { get; set; }

        public string PhysicalAddressLine3 { get; set; }

        public string PhysicalAddressLine4 { get; set; }

        public string LinkedProjectKey { get; set; }

        public string LinkedProjectName { get; set; }

        public string ActivityHoursPerWeek { get; set; }

        public DateTime DescriptionModificationDate { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}