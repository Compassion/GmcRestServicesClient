using System;

namespace GmcRestServicesClient.Models
{
    public class ProgramImplementor
    {
        /// <summary>
        /// Code indicating whether a Program Implementor is a CDSP Implementor or a CSP Implementor
        /// </summary>
        public string ProgramImplementorTypeCode { get; set; }
        
        /// <summary>
        /// Idenfities an implementor
        /// </summary>
        public string ImplementorKey { get; set; }
        
        /// <summary>
        /// Key identifying a CDSP or CSP Implementor
        /// </summary>
        public string ImplementorKeyLegacy { get; set; }
        
        /// <summary>
        /// Implementor name
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Date partnership with the Implementor began
        /// </summary>
        public DateTime StartDate { get; set; }
        
        /// <summary>
        /// Date the last annual implementor information update was received
        /// </summary>
        public DateTime LastReviewDate { get; set; }
        
        /// <summary>
        /// One character status field indicating if the project is (A)ctive, on (P)hase-out, or (T)erminated. There is not a suspended status. One of the letters in parentheses are returned in the response.
        /// </summary>
        public string Status { get; set; }
        
        /// <summary>
        /// Status made available to external client
        /// </summary>
        public string ExternalStatus { get; set; }
        
        /// <summary>
        /// Status made available to external client
        /// </summary>
        public DateTime StatusDate { get; set; }
        
        /// <summary>
        /// Description of the implementing project
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// Key identifying the local church partner which is implementing the CSP or CDSP program
        /// </summary>
        public string LocalChurchPartnerID { get; set; }
        
        /// <summary>
        /// Name of the local church partner
        /// </summary>
        public string OrganizationName { get; set; }
        
        /// <summary>
        /// Language(s) used during a church service in the local church partner
        /// </summary>
        public string ChurchServiceLanguages { get; set; }
        
        /// <summary>
        /// High precision GPS latitude of the location of the local church partner
        /// </summary>
        public string GpsCoordinateLatitudeHighPrecision { get; set; }
        
        /// <summary>
        /// Low precision GPS latitude of the location of the local church partner
        /// </summary>
        public string GpsCoordinateLatitudeLowPrecision { get; set; }
        
        /// <summary>
        /// High precision GPS longitude of the location of the local church partner
        /// </summary>
        public string GpsCoordinateLongitudeHighPrecision { get; set; }
        
        /// <summary>
        /// Low precision GPS longitude of the location of the local church partner
        /// </summary>
        public string GpsCoordinateLongitudeLowPrecision { get; set; }
        
        /// <summary>
        /// Code indicating if the local church partner is in an HIV/Aids infected area. Values can be "AFFTCD" or "NOTAFF".
        /// </summary>
        public string HivCategory { get; set; }
        
        /// <summary>
        /// Month school begins each year
        /// </summary>
        public string MonthSchoolYearBegins { get; set; }
        
        /// <summary>
        /// Denomination of the country where the local church partner is located and with which the local church partner is affiliated
        /// </summary>
        public string CountryDenomination { get; set; }
        
        /// <summary>
        /// Denomination in the US or Global Partner(s) that is affiliated with the local church partner
        /// </summary>
        public string WesternDenomination { get; set; }
        
        /// <summary>
        /// Name of the community in which the local church partner resides
        /// </summary>
        public string CommunityName { get; set; }
        
        /// <summary>
        /// Name for a country as recorded by the International Organization for Standardization (ISO) in the ISO 3166-1 standard
        /// </summary>
        public string IsoCountryName { get; set; }
        
        /// <summary>
        /// Two-character code assigned to a country by the International Organization for Standardization (ISO) as defined in the ISO 3166-1 standard
        /// </summary>
        public string IsoCountryCode { get; set; }
        
        /// <summary>
        /// Common name of a country used by Compassion International
        /// </summary>
        public string CountryCommonName { get; set; }
        
        /// <summary>
        /// Identifies community
        /// </summary>
        public string CommunityID { get; set; }
        
        public string StatusComment { get; set; }
        
        public DateTime DescriptionModificationDate { get; set; }
        
        /// <summary>
        /// Flag indicating if gifts may be disbursed for children in this program
        /// </summary>
        public bool DisburseGifts { get; set; }
        
        /// <summary>
        /// Flag indicating if funds, not including gifts, can be disbursed to the CSP or CDSP Implementor
        /// </summary>
        public bool DisburseFunds { get; set; }
        
        /// <summary>
        /// Project activities targeted to CSP Child or CSP Caregiver spiritual development
        /// </summary>
        public string SpiritualActivities { get; set; }
        
        /// <summary>
        ///  Activities for non-school children
        /// </summary>
        public string ActivitiesForNonSchoolChildren { get; set; }
        
        /// <summary>
        /// Project activities targeted to CSP Child or CSP Caregiver cognitive and/or vocational development
        /// </summary>
        public string CognitiveOrVocationalActivities { get; set; }
        
        /// <summary>
        /// Project activities not targeted to a particular development activity
        /// </summary>
        public string OtherActivities { get; set; }
        
        /// <summary>
        /// Project  activities targeted to parent and family development
        /// </summary>
        public string ParentOrFamilyActivities { get; set; }
        
        /// <summary>
        /// Project activities targeted to child's physical development
        /// </summary>
        public string PhysicalOrHealthActivities { get; set; }
        
        /// <summary>
        /// Project activities targeted to the child's social / emothional evelopment
        /// </summary>
        public string SocialOrEmotionalActivities { get; set; }
        
        public string ActivityHoursPerWeek { get; set; }
        
        public string PercentNotInSchool { get; set; }
        
        /// <summary>
        /// Reason more than 25% of the registered beneficiaries are not in school
        /// </summary>
        public string PercentNotInSchoolReason { get; set; }
        
        /// <summary>
        /// Percentage of registered beneficiaries who have completed elementary school
        /// </summary>
        public string PercentCompletingElementarySchool { get; set; }
        
        /// <summary>
        /// Percentage of registered beneficiaries who have completed secondary school
        /// </summary>
        public string PercentCompletingSecondarySchool { get; set; }
        
        public string ElementaryCompletionStatus { get; set; }
        
        public string SecondaryCompletionStatus { get; set; }
        
        /// <summary>
        /// Flag indicating if the Local Church Partner has electricity in the building
        /// </summary>
        public bool ChurchHasElectricity { get; set; }
        
        /// <summary>
        /// Flag indicating if the Local Church Partner has a phone
        /// </summary>
        public bool ChurchHasPhone { get; set; }
        
        /// <summary>
        /// Flag indicating if the Local Church Partner owns the building they are utilizing
        /// </summary>
        public bool ChurchOwnsBuilding { get; set; }
        
        /// <summary>
        /// Number of employess paid by the Local Church Partner
        /// </summary>
        public string PaidStaffCount { get; set; }
        
        /// <summary>
        /// Number of hours volunteers work in a month
        /// </summary>
        public string MonthlyVolunteerHours { get; set; }
        
        public string LinkedProjectKey { get; set; }
        
        public string LinkedProjectName { get; set; }
        
        /// <summary>
        /// Date the record was created or modified
        /// </summary>
        public DateTime LastModifiedDate { get; set; }
    }
}