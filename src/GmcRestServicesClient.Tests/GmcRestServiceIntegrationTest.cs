using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GmcRestServicesClient.Models;
using NUnit.Framework;

namespace GmcRestServicesClient.Tests
{
    [TestFixture]
    [Ignore("Integration Tests")]
    public class GmcRestServiceIntegrationTest
    {
        private const string BaseUrl = "https://api2.compassion.com/iptest/ci/v1/";

        private const string ApiKey = ""; // Set this to your Mashery API key for testing.

        private GmcRestService service;

        [TestFixtureSetUp]
        public void SetUp()
        {
            service = new GmcRestService(BaseUrl, ApiKey);
        }

        [Test]
        public void GetChildInformation()
        {
            var child = service.GetChildInformation("EC5500279");
        }

        [Test]
        public void GetCdspImplementor()
        {
            var cdspImplementor = service.GetCdspImplementor("ID125");
        }

        [Test]
        public void GetChildCaseStudy()
        {
            var childCaseStudy = service.GetChildCaseStudy("EC5500279");
        }

        [Test]
        public void GetChildExitDetails()
        {
            var exitDetails = service.GetChildExitDetails("IN6890248");
        }

        [Test]
        public void GetChildImage()
        {
            //var childImage = service.GetChildImage("EC5500279", 900, 600, 72, ChildImageFormat.Jpeg, ChildImageType.Fullshot);
            var childImage = service.GetChildImage("EC5500279", null, null, null, null, ChildImageType.Raw);
            File.WriteAllBytes("imagetest.jpg", childImage.Image.ImageDataBytes);
        }

        [Test]
        public void GetCommunity()
        {
            var community = service.GetCommunity(6618);
        }

        [Test]
        public void GetCountryByIsoNumericCode()
        {
            var country = service.GetCountryByIsoNumericCode(068);
        }

        [Test]
        public void GetCountryByIsoAlpha2Code()
        {
            var country = service.GetCountryByIsoAlpha2Code("SV");
        }

        [Test]
        public void GetCountryByLegacyCompassionCode()
        {
            var country = service.GetCountryByLegacyCompassionCode("ES");
        }

        [Test]
        public void GetCspImplementor()
        {
            var cspImplementor = service.GetCspImplementor("HACS1");
        }

        [Test]
        public void GetLocalChurchPartner()
        {
            var churchPartner = service.GetChurchPartner(5);
        }

        [Test]
        public void GetProgramImplementor()
        {
            var churchPartner = service.GetProgramImplementor("IN689");
        }

        [Test]
        public void GetProjectAgeGroups()
        {
            var projectAgeGroups = service.GetProjectAgeGroups("IN689");
        }
    }
}
