using System;
using System.Collections.Generic;
using System.Configuration;
using AutoMapper;
using AutoMapper.Mappers;
using GmcRestServicesClient.AutoMapper;
using GmcRestServicesClient.Models;
using GmcRestServicesClient.Models.Rest;

namespace GmcRestServicesClient
{
    public class GmcRestService : IGmcRestService
    {
        private static readonly IMappingEngine Mapper;

        private readonly IRestService restService;

        static GmcRestService()
        {
            // Mapping is currently required due to need to strip TimeZone portion of DateTimes from web service. Both RestSharp and Json.Net didn't allow easy custom date parsing to achieve this.
            // Not using static Mapper.CreateMap method directly as don't want to conflict with any mappings used by clients of our library. 
            // Mapping between classes may be able to be removed in future versions of the API
            Mapper = new MappingEngine(CreateAutoMapConfig());
        }

        private static ConfigurationStore CreateAutoMapConfig()
        {
            var mappingConfiguration = new ConfigurationStore(new TypeMapFactory(), MapperRegistry.Mappers);
            mappingConfiguration.CreateMap<string, DateTime?>().ConvertUsing<DateConverter>();
            mappingConfiguration.CreateMap<string, DateTime>().ConvertUsing<DateConverter>();
            mappingConfiguration.CreateMap<ChildRest, Child>();
            mappingConfiguration.CreateMap<CdspImplementorRest, CdspImplementor>();
            mappingConfiguration.CreateMap<ChildCaseStudyRest, ChildCaseStudy>();
            mappingConfiguration.CreateMap<ChildCaseStudySchoolingRest, ChildCaseStudySchooling>();
            mappingConfiguration.CreateMap<ChildExitDetailsRest, ChildExitDetails>();
            mappingConfiguration.CreateMap<CspImplementorRest, CspImplementor>();
            mappingConfiguration.CreateMap<LocalChurchPartnerRest, LocalChurchPartner>();
            mappingConfiguration.CreateMap<ProgramImplementorRest, ProgramImplementor>();
            return mappingConfiguration;
        }

        /// <summary>
        /// Parameters are optional. If not provided, they are loaded from App.config file.
        /// </summary>
        /// <param name="baseUrl">Base URL of the webservice. If not provided or null, it loaded from App.config "GmcRestServicesUrl" appSettings key value.</param>
        /// <param name="apiKey">API key for the webservice. If not provided or null, it loaded from App.config "GmcRestServicesClientApiKey" appSettings key value.</param>
        public GmcRestService(string baseUrl = null, string apiKey = null)
        {
            baseUrl = baseUrl ?? ConfigurationManager.AppSettings["GmcRestServicesUrl"];
            apiKey = apiKey ?? ConfigurationManager.AppSettings["GmcRestServicesClientApiKey"];
            restService = new RestService(baseUrl, apiKey);
        }

        internal GmcRestService(IRestService restService)
        {
            this.restService = restService;
        }

        public CdspImplementor GetCdspImplementor(string cdspImplementorKeyLegacy)
        {
            var cdspImplementorRest = restService.Get<CdspImplementorRest>(string.Format("cdspimplementors/{0}", cdspImplementorKeyLegacy));
            return Mapper.Map<CdspImplementor>(cdspImplementorRest);
        }

        public ChildCaseStudy GetChildCaseStudy(string childKey)
        {
            var childCaseStudyRest = restService.Get<ChildCaseStudyRest>(string.Format("children/{0}/casestudy", childKey));
            return Mapper.Map<ChildCaseStudy>(childCaseStudyRest);
        }

        public ChildImage GetChildImage(string childKey, int? height = null, int? width = null, int? dpi = null, int? quality = null, ChildImageFormat? imageFormat = null, ChildImageType? imageType = null)
        {
            var parameters = new Dictionary<string, string>();
            if (height.HasValue)
                parameters.Add("height", height.ToString());
            if (width.HasValue)
                parameters.Add("width", width.ToString());
            if (dpi.HasValue)
                parameters.Add("dpi", dpi.ToString());
            if (quality.HasValue)
                parameters.Add("quality", quality.ToString());
            if (imageFormat.HasValue)
                parameters.Add("imageFormat", imageFormat.ToString());
            if (imageType.HasValue)
                parameters.Add("imageType", imageType.ToString());

            return restService.Get<ChildImage>(string.Format("children/{0}/image/2015/03", childKey), parameters);
        }

        public Child GetChildInformation(string childKey)
        {
            var childRest = restService.Get<ChildRest>(string.Format("children/{0}/information", childKey));
            return Mapper.Map<Child>(childRest);
        }

        public ChildExitDetails GetChildExitDetails(string childKey)
        {
            var childCaseStudyRest = restService.Get<ChildExitDetailsRest>(string.Format("children/{0}/exitdetails", childKey));
            return Mapper.Map<ChildExitDetails>(childCaseStudyRest);
        }

        public Community GetCommunity(int communityId)
        {
            return restService.Get<Community>(string.Format("communities/{0}", communityId));
        }

        public Country GetCountryByIsoNumericCode(int isoCountryNumericCode)
        {
            return restService.Get<Country>(string.Format("countries/{0}", isoCountryNumericCode));
        }

        public Country GetCountryByIsoAlpha2Code(string isoCountryAlpha2Code)
        {
            return restService.Get<Country>(string.Format("countries/iso/{0}", isoCountryAlpha2Code));
        }

        public Country GetCountryByLegacyCompassionCode(string compassionCountryCode)
        {
            return restService.Get<Country>(string.Format("countries/legacy/{0}", compassionCountryCode));
        }

        public CspImplementor GetCspImplementor(string cspImplementorKeyLegacy)
        {
            var cdspImplementorRest = restService.Get<CspImplementorRest>(string.Format("cspimplementors/{0}", cspImplementorKeyLegacy));
            return Mapper.Map<CspImplementor>(cdspImplementorRest);
        }

        public LocalChurchPartner GetLocalChurchPartner(int localChurchPartnerId)
        {
            var cdspImplementorRest = restService.Get<LocalChurchPartnerRest>(string.Format("localchurchpartners/{0}", localChurchPartnerId));
            return Mapper.Map<LocalChurchPartner>(cdspImplementorRest);
        }

        public ProgramImplementor GetProgramImplementor(string projectKey)
        {
            var programImplementorRest = restService.Get<ProgramImplementorRest>(string.Format("programimplementors/{0}", projectKey));
            return Mapper.Map<ProgramImplementor>(programImplementorRest);
        }

        public ProjectAgeGroups GetProjectAgeGroups(string projectKey)
        {
            return restService.Get<ProjectAgeGroups>(string.Format("cdspimplementors/{0}/agegroups", projectKey));
        }
    }
}
