namespace GmcRestServicesClient.Models
{
    public class Country
    {
        /// <summary>
        /// Code assigned to a country by the International Organization for Standardization (ISO).
        /// </summary>
        public int CountryID { get; set; }

        /// <summary>
        /// Name for a country as recorded by the International Organization for Standardization (ISO) in the ISO 3166-1 standard.
        /// </summary>
        public string IsoCountryName { get; set; }

        /// <summary>
        /// Two-character code assigned to a country by the International Organization for Standardization (ISO) as defined in the ISO 3166-1 standard.
        /// </summary>
        public string IsoCountryCode { get; set; }
        
        /// <summary>
        /// Common name of a country as used by Compassion International.
        /// </summary>
        public string CountryCommonName { get; set; }
        
        /// <summary>
        /// Description of the country.
        /// </summary>
        public string CountryDescription { get; set; }
        
        /// <summary>
        /// Telephone code for international dialing.
        /// </summary>
        public string CountryInternationalPhoneCode { get; set; }
        
        /// <summary>
        /// Population of the country.
        /// </summary>
        public string CountryPopulation { get; set; }
        
        /// <summary>
        /// Government type of the country.
        /// </summary>
        public string GovernmentType { get; set; }
        
        /// <summary>
        /// Predominate religion of the country.
        /// </summary>
        public string OfficialReligion { get; set; }
        
        /// <summary>
        /// Official language of the country.
        /// </summary>
        public string OfficialLanguage { get; set; }
        
        /// <summary>
        /// Official currency of the country.
        /// </summary>
        public string OfficialCurrency { get; set; }
        
        /// <summary>
        /// Life expectancy of person in the country.
        /// </summary>
        public string LifeExpectancy { get; set; }
        
        /// <summary>
        /// Per capita income of individuals in the country.
        /// </summary>
        public string PerCapitaIncomeInUSDollars { get; set; }
        
        /// <summary>
        /// Number of infants that die per 1000 born.
        /// </summary>
        public string InfantMortalityRate { get; set; }
        
        /// <summary>
        /// Number of children under five years of age that die per 1000 that are born.
        /// </summary>
        public string Under5MortalityRate { get; set; }
        
        /// <summary>
        /// Percent of children that reach US equivalent of a fifth grade education.
        /// </summary>
        public string PercentOfChildrenThatReachUS5thGradeEquivalent { get; set; }
        
        /// <summary>
        /// Average years it takes a child to complete primary education.
        /// </summary>
        public string AverageYearsToCompletePrimarySchool { get; set; }
        
        /// <summary>
        /// Expected number of years it takes a child to complete primary education.
        /// </summary>
        public string ExpectedYearsToCompletePrimarySchool { get; set; }
        
        /// <summary>
        /// Percentage of population that is Hindu.
        /// </summary>
        public string PercentOfPopulationHindu { get; set; }
        
        /// <summary>
        /// Percent of population that is Animist.
        /// </summary>
        public string PercentOfPopulationAnimist { get; set; }
        
        /// <summary>
        /// Percentage of population that is Buddhist.
        /// </summary>
        public string PercentOfPopulationBuddhist { get; set; }
        
        /// <summary>
        /// Percent of population that is Catholic.
        /// </summary>
        public string PercentOfPopulationCatholic { get; set; }
        
        /// <summary>
        /// Percentage of population that is Protestant.
        /// </summary>
        public string PercentOfPopulationProtestant { get; set; }
        
        /// <summary>
        /// Percent of population that is Muslim.
        /// </summary>
        public string PercentOfPopulationMuslim { get; set; }
    }
}