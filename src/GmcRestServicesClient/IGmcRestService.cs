using GmcRestServicesClient.Models;

namespace GmcRestServicesClient
{
    public interface IGmcRestService
    {
        /// <summary>
        /// Provides information on a CDSP implementor based on the CDSP Implementor Key.
        /// </summary>
        /// <param name="cdspImplementorKeyLegacy">The legacy CDSP Implementor key (e.g., "AB123")</param>
        /// <returns>CDSP Implementor information</returns>
        CdspImplementor GetCdspImplementor(string cdspImplementorKeyLegacy);

        /// <summary>
        /// Returns data for an child actively enrolled in the Child Development Sponsorship Program (CDSP). Each field from ecase is included as an element in the response.
        /// </summary>
        /// <param name="childKey">Code assigned by Compassion International when the child is registered in the Child Sponsorship Program (e.g., "AB1234567")</param>
        /// <returns>Child case study information</returns>
        ChildCaseStudy GetChildCaseStudy(string childKey);

        /// <summary>
        /// Get Child Exit Details, provides details of a child exit from a CDSP program. 
        /// </summary>
        /// <param name="childKey">Code assigned by Compassion International when the child is registered in the Child Sponsorship Program (e.g., "AB1234567").</param>
        /// <returns>Child exit details</returns>
        ChildExitDetails GetChildExitDetails(string childKey);

        /// <summary>
        /// <para>Get Child Image, provides the most recent image of a child based on an active child key. The image is formatted to input specifications.</para>
        /// <para>Customer formatting includes:</para>
        /// <list type="bullet">
        ///   <item><description>Image can be returned as .jpeg, .gif or .bmp files</description></item>
        ///   <item><description>Image width can be modified</description></item>
        ///   <item><description>Image height can be modified</description></item>
        ///   <item><description>Image resolution and quality can be modified</description></item>
        ///   <item><description>Image type can be chosen.  If Image type equals "raw" is used, all other formatting parameters are ignored. ImageType "raw" will return the head coordinates. All other ImageTypes will not return head coordinates.</description></item>
        /// </list>
        /// <para>There are three parameters to use to get the required type of picture.</para>
        /// <list type="bullet">
        ///   <item><description>DPI (dots per inch)</description></item>
        ///   <item><description>Height (pixels)</description></item>
        ///   <item><description>Width (pixels)</description></item>
        /// </list>
        /// <para>A website example would be DPI=72, Height=400, Width=300</para>
        /// <para>A print example would be DPI=300, Height= (desired inches high x DPI), Width= (desired inches wide x DPI). A print picture of 4 inches high by 3 inches wide the settings would be:</para>
        /// <list type="bullet">
        ///   <item><description>DPI=300</description></item>
        ///   <item><description>Height=1200</description></item>
        ///   <item><description>Width=900</description></item>
        /// </list>
        /// <para>If you need a higher DPI, adjust the height and width accordingly, keeping in mind that the bigger the picture the bigger the payload and slower the response time (e.g., "AB1234567").</para>
        /// </summary>
        /// <param name="childKey">Code assigned by Compassion International when the child is registered in the Child Sponsorship Program or the Leadership Development Program (e.g., "AB1234567").</param>
        /// <param name="height">Optional image height in pixels [Valid values: 1-5000; Default: 600]</param>
        /// <param name="width">Optional image width in pixels [Valid values: 1-5000; Default: 400]</param>
        /// <param name="dpi">Optional image dots per inch [Valid values: 1-1200; Default: 72]</param>
        /// <param name="quality">Optional image quality (a lower number is poorer quality) [Valid values: 1-100; Default: 100]</param>
        /// <param name="imageFormat">Optional type of image format [Default: Jpeg]</param>
        /// <param name="imageType">Optional type of image that can be returned [Default: Headshot]</param>
        /// <returns>Child image data</returns>
        ChildImage GetChildImage(string childKey, int? height = null, int? width = null, int? dpi = null, int? quality = null, ChildImageFormat? imageFormat = null, ChildImageType? imageType = null);

        /// <summary>
        ///  Provides information on a child enrolled in the Child Development Sponsorship Program (CDSP).
        /// </summary>
        /// <param name="childKey">Code assigned by Compassion International when the child is registered in the Child Sponsorship Program (e.g., "AB1234567").</param>
        /// <returns>Child information</returns>
        Child GetChildInformation(string childKey);

        /// <summary>
        ///  Provides information on a single community in which Compassion partners with a local church.
        /// </summary>
        /// <param name="communityId">Compassion system-generated identifier</param>
        /// <returns></returns>
        Community GetCommunity(int communityId);

        /// <summary>
        /// Gets country information by ISO 3166-1 numeric code.
        /// </summary>
        /// <param name="isoCountryNumericCode">Three-digit code assigned to a country by the International Organization for Standardization (ISO).</param>
        /// <returns>Country information</returns>
        Country GetCountryByIsoNumericCode(int isoCountryNumericCode);

        /// <summary>
        /// Gets country information by ISO 3166-1 alpha-2 code.
        /// </summary>
        /// <param name="isoCountryAlpha2Code">Two-character code assigned to a country by the International Organization for Standardization (ISO) as defined in the ISO 3166-1 standard.</param>
        /// <returns>Country information</returns>
        Country GetCountryByIsoAlpha2Code(string isoCountryAlpha2Code);

        /// <summary>
        /// Gets country information by legacy two-character country code used by Compassion International.
        /// </summary>
        /// <param name="compassionCountryCode">Two-character legacy country code that is used to identify field offices within Compassion International.</param>
        /// <returns>Country information</returns>
        Country GetCountryByLegacyCompassionCode(string compassionCountryCode);

        /// <summary>
        /// Provides information on a CSP implementor based on the CSP Implementor Key.
        /// </summary>
        /// <param name="cspImplementorKeyLegacy">The legacy CSP Implementor Id (e.g., "ABCD1")</param>
        /// <returns></returns>
        CspImplementor GetCspImplementor(string cspImplementorKeyLegacy);

        /// <summary>
        /// Provides information on a church partner and the community they reside in based on the Local Church Partner Id.
        /// </summary>
        /// <param name="localChurchPartnerId">The Local Church Partner Id</param>
        /// <returns>Local Church Partner information</returns>
        LocalChurchPartner GetLocalChurchPartner(int localChurchPartnerId);

        /// <summary>
        /// Provides information on specific CDSP and CSP organizations which partner with Compassion International's to implement and administrate one or more ministry intervention programs.
        /// </summary>
        /// <param name="projectKey">Key identifying a CDSP or CSP project (e.g., "AB123")</param>
        /// <returns></returns>
        ProgramImplementor GetProgramImplementor(string projectKey);

        /// <summary>
        /// Provides a project's basic hourly, daily, and monthly information based on age groups. This service applies only to CDSP Implementors. 
        /// </summary>
        /// <param name="projectKey">Key identifying a CDSP Implementor (e.g., "AB123")</param>
        /// <returns></returns>
        ProjectAgeGroups GetProjectAgeGroups(string projectKey);
    }
}