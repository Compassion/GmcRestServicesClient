namespace GmcRestServicesClient.Models
{
    public class Community
    {
        /// <summary>
        /// Compassion system-generated identifier for a community
        /// </summary>
        public int CommunityID { get; set; }
        
        /// <summary>
        /// Name of the community
        /// </summary>
        public string CommunityName { get; set; }
        
        /// <summary>
        /// Identifier of the country in which the community is located
        /// </summary>
        public int CountryID { get; set; }
        
        /// <summary>
        /// Description that helps to locate the community on a map
        /// </summary>
        public string LocationFromClosestCity { get; set; }
        
        /// <summary>
        /// Textual description of the distance from the community to the closest major city
        /// </summary>
        public string DistanceFromClosestCity { get; set; }
        
        /// <summary>
        /// Name of the major city that is closest to the community
        /// </summary>
        public string ClosestCityName { get; set; }
        
        /// <summary>
        /// Typical unemployment rate in the community
        /// </summary>
        public string UnemploymentRate { get; set; }
        
        /// <summary>
        /// Description of the most common foods eaten in the community
        /// </summary>
        public string PrimaryDiet { get; set; }
        
        /// <summary>
        /// Identifier of the type of climate that affects the area in which the community is located
        /// </summary>
        public string ClimateID { get; set; }
        
        /// <summary>
        /// Description of the type of climate in which the community is located
        /// </summary>
        public string ClimateDescription { get; set; }
        
        /// <summary>
        /// Identifier of the type of terrain that exists in the area in which the community is located
        /// </summary>
        public string TerrainID { get; set; }
        
        /// <summary>
        /// Description of the type of terrain in which the community is located
        /// </summary>
        public string TerrainDescription { get; set; }
        
        /// <summary>
        /// Identifier of the primary occupation within the community
        /// </summary>
        public int PrimaryOccupationID { get; set; }
        
        /// <summary>
        /// Three character code  of the primary occupation
        /// </summary>
        public string PrimaryOccupationCode { get; set; }
        
        /// <summary>
        /// Title of the primary occupation
        /// </summary>
        public string PrimaryOccupationTitle { get; set; }
        
        /// <summary>
        /// Identifier of the main religion within the community
        /// </summary>
        public int MainReligionID { get; set; }
        
        /// <summary>
        /// Description of  the main religion within the community
        /// </summary>
        public string MainReligionDescription { get; set; }
        
        /// <summary>
        /// Identifier of the building material that is used for typical floors within the community
        /// </summary>
        public string TypicalFloorBuildingMaterialID { get; set; }
        
        /// <summary>
        /// Description of the building material that is used for typical floors within the community
        /// </summary>
        public string TypicalFloorBuildingMaterialDescription { get; set; }
        
        /// <summary>
        /// Identifier of the building material that is used for typical walls within the community
        /// </summary>
        public string TypicalWallBuildingMaterialID { get; set; }
        
        /// <summary>
        /// Description of the building material that is used for typical walls within the community
        /// </summary>
        public string TypicalWallBuildingMaterialDescription { get; set; }
        
        /// <summary>
        /// Identifier of the building material that is used for typical roofs within the community
        /// </summary>
        public string TypicalRoofBuildingMaterialID { get; set; }
        
        /// <summary>
        /// Description of the building material that is used for typical roofs within the community
        /// </summary>
        public string TypicalRoofBuildingMaterialDescription { get; set; }
        
        /// <summary>
        /// Description of the highest level of education available within the community
        /// </summary>
        public string HighestEducationAvailable { get; set; }
        
        /// <summary>
        /// Description of the vocational training that is available within the community
        /// </summary>
        public string VocationalTrainingAvailable { get; set; }
        
        /// <summary>
        /// Month(s) that are considered the rainy month(s) within the community
        /// </summary>
        public string RainyMonths { get; set; }
        
        /// <summary>
        /// Month(s) that are considered the planting month(s) within the community
        /// </summary>
        public string PlantingMonths { get; set; }
        
        /// <summary>
        /// Month(s) that are considered the harvest month(s) within the community
        /// </summary>
        public string HarvestMonths { get; set; }
        
        /// <summary>
        /// Month(s) that are considered the hunger month(s) within the community
        /// </summary>
        public string HungerMonths { get; set; }
        
        /// <summary>
        /// Month(s) that are considered the illness month(s) within the community
        /// </summary>
        public string IllnessMonths { get; set; }
        
        /// <summary>
        /// Typical monthly income of a family in US Dollars
        /// </summary>
        public string FamilyMonthlyIncome { get; set; }
        
        /// <summary>
        /// Description of the distance to the neareast medical assistance - can be in kilometers, meters, minutes, hours
        /// </summary>
        public string DistanceToMedicalAssistance { get; set; }
        
        /// <summary>
        /// Time it takes to get to the nearest medical assistance
        /// </summary>
        public string TypicalTransportationTimeToMedicalAssistance { get; set; }
        
        /// <summary>
        /// Primary method of transportation used to reach medical help
        /// </summary>
        public string MedicalTransportationType { get; set; }
        
        /// <summary>
        /// Population of the community
        /// </summary>
        public string CommunityPopulation { get; set; }
        
        /// <summary>
        /// Month the average temperature is the hottest
        /// </summary>
        public string WarmestMonth { get; set; }
        
        /// <summary>
        /// Average temperature of the hottest month
        /// </summary>
        public string WarmestMonthAverageTemperature { get; set; }
        
        /// <summary>
        /// Month the average temperature is the coldest
        /// </summary>
        public string CoolestMonth { get; set; }
        
        /// <summary>
        /// Average temperature of the coldest month
        /// </summary>
        public string CoolestMonthAverageTemperature { get; set; }
        
        /// <summary>
        /// Date the community information was last reviewed
        /// </summary>
        public string DateOfLastReview { get; set; }
        
        /// <summary>
        /// Date the community information was last updated
        /// </summary>
        public string DateOfLastUpdate { get; set; }
        
        /// <summary>
        /// Common health problems of a community
        /// </summary>
        public string CommonHealthProblems { get; set; }
        
        /// <summary>
        /// Typical economic needs of a community
        /// </summary>
        public string EconomicNeeds { get; set; }
        
        /// <summary>
        /// Typical educational needs of a community
        /// </summary>
        public string EducationalNeeds { get; set; }
        
        /// <summary>
        /// General comments about the environment in a community
        /// </summary>
        public string EnvironmentComment { get; set; }
        
        /// <summary>
        /// National and religious holidays celebrated in a community
        /// </summary>
        public string NationalReligiousHolidays { get; set; }
        
        /// <summary>
        /// Primary ethnic group(s) and language(s) spoken in a community
        /// </summary>
        public string PrimaryEthnicGroup { get; set; }
        
        /// <summary>
        /// Typical social needs of a community
        /// </summary>
        public string SocialNeeds { get; set; }
        
        /// <summary>
        /// Typical spiritual needs of a community
        /// </summary>
        public string SpiritualNeeds { get; set; }
        
        /// <summary>
        /// Traditions, rituals and customs that are typically practiced in a community
        /// </summary>
        public string TraditionsRitualsCustoms { get; set; }
        
        /// <summary>
        /// Percentage of children not in school in a community
        /// </summary>
        public string PercentageOfChildrenNotInSchool { get; set; }
        
        /// <summary>
        /// Percentage of children completeing elementary school in a community
        /// </summary>
        public string PercentCompletingElementarySchool { get; set; }
        
        /// <summary>
        /// Percentage of children completing secondary school in a community
        /// </summary>
        public string PercentCompletingSecondarySchool { get; set; }
    }
}