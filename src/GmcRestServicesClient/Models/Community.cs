namespace GmcRestServicesClient.Models
{
    public class Community
    {
        public int CommunityID { get; set; }
        
        public string CommunityName { get; set; }
        
        public int CountryID { get; set; }
        
        public string LocationFromClosestCity { get; set; }
        
        public string DistanceFromClosestCity { get; set; }
        
        public string ClosestCityName { get; set; }
        
        public string UnemploymentRate { get; set; }
        
        public string PrimaryDiet { get; set; }
        
        public string ClimateID { get; set; }
        
        public string ClimateDescription { get; set; }
        
        public string TerrainID { get; set; }
        
        public string TerrainDescription { get; set; }
        
        public int PrimaryOccupationID { get; set; }
        
        public string PrimaryOccupationCode { get; set; }
        
        public string PrimaryOccupationTitle { get; set; }
        
        public int MainReligionID { get; set; }
        
        public string MainReligionDescription { get; set; }
        
        public string TypicalFloorBuildingMaterialID { get; set; }
        
        public string TypicalFloorBuildingMaterialDescription { get; set; }
        
        public string TypicalWallBuildingMaterialID { get; set; }
        
        public string TypicalWallBuildingMaterialDescription { get; set; }
        
        public string TypicalRoofBuildingMaterialID { get; set; }
        
        public string TypicalRoofBuildingMaterialDescription { get; set; }
        
        public string HighestEducationAvailable { get; set; }
        
        public string VocationalTrainingAvailable { get; set; }
        
        public string RainyMonths { get; set; }
        
        public string PlantingMonths { get; set; }
        
        public string HarvestMonths { get; set; }
        
        public string HungerMonths { get; set; }
        
        public string IllnessMonths { get; set; }
        
        public string FamilyMonthlyIncome { get; set; }
        
        public string DistanceToMedicalAssistance { get; set; }
        
        public string TypicalTransportationTimeToMedicalAssistance { get; set; }
        
        public string MedicalTransportationType { get; set; }
        
        public string CommunityPopulation { get; set; }
        
        public string WarmestMonth { get; set; }
        
        public string WarmestMonthAverageTemperature { get; set; }
        
        public string CoolestMonth { get; set; }
        
        public string CoolestMonthAverageTemperature { get; set; }
        
        public string DateOfLastReview { get; set; }
        
        public string DateOfLastUpdate { get; set; }
        
        public string CommonHealthProblems { get; set; }
        
        public string EconomicNeeds { get; set; }
        
        public string EducationalNeeds { get; set; }
        
        public string EnvironmentComment { get; set; }
        
        public string NationalReligiousHolidays { get; set; }
        
        public string PrimaryEthnicGroup { get; set; }
        
        public string SocialNeeds { get; set; }
        
        public string SpiritualNeeds { get; set; }
        
        public string TraditionsRitualsCustoms { get; set; }
        
        public string PercentageOfChildrenNotInSchool { get; set; }
        
        public string PercentCompletingElementarySchool { get; set; }
        
        public string PercentCompletingSecondarySchool { get; set; }
    }
}