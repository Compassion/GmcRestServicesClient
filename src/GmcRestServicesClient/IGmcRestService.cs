using GmcRestServicesClient.Models;

namespace GmcRestServicesClient
{
    public interface IGmcRestService
    {
        CdspImplementor GetCdspImplementor(string cdspImplementorKeyLegacy);

        ChildCaseStudy GetChildCaseStudy(string childKey);

        ChildExitDetails GetChildExitDetails(string childKey);

        ChildImage GetChildImage(string childKey, int? height = null, int? width = null, int? dpi = null, ChildImageFormat? imageFormat = null, ChildImageType? imageType = null);

        Child GetChildInformation(string childKey);

        Community GetCommunity(int communityId);

        /// <summary>
        /// Gets country information by ISO 3166-1 numeric code.
        /// </summary>
        /// <param name="isoCountryNumericCode">ISO 3166-1 numeric code</param>
        /// <returns></returns>
        Country GetCountryByIsoNumericCode(int isoCountryNumericCode);

        /// <summary>
        /// Gets country information by ISO 3166-1 alpha-2 code.
        /// </summary>
        /// <param name="isoCountryAlpha2Code">ISO 3166-1 alpha-2 code</param>
        /// <returns></returns>
        Country GetCountryByIsoAlpha2Code(string isoCountryAlpha2Code);

        /// <summary>
        /// Gets country information by legacy two-character country code used by Compassion International.
        /// </summary>
        /// <param name="compassionCountryCode">Legacy two-character country code used by Compassion International</param>
        /// <returns></returns>
        Country GetCountryByLegacyCompassionCode(string compassionCountryCode);

        CspImplementor GetCspImplementor(string cspImplementorKeyLegacy);

        LocalChurchPartner GetChurchPartner(int localChurchPartnerId);

        ProgramImplementor GetProgramImplementor(string projectKey);

        ProjectAgeGroups GetProjectAgeGroups(string projectKey);
    }
}