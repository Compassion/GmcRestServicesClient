using System;
using System.Collections.Generic;
using GmcRestServicesClient.Models;
using GmcRestServicesClient.Models.Rest;
using NUnit.Framework;
using Rhino.Mocks;

namespace GmcRestServicesClient.Tests
{
    [TestFixture]
    public class GmcRestServiceTests
    {
        [Test]
        public void GetCdspImplementor()
        {
            const string cdspImplementorKeyLegacy = "AB123";
            var returnedRestObject = new CdspImplementorRest { CdspImplementorKeyLegacy = cdspImplementorKeyLegacy, StartDate = "2001-02-03T04:05:06-06:00" };

            var restService = MockRepository.GenerateMock<IRestService>();
            restService.Expect(r => r.Get<CdspImplementorRest>("cdspimplementors/AB123"))
                .Return(returnedRestObject);

            var gmcRestService = new GmcRestService(restService);
            var cdspImplementor = gmcRestService.GetCdspImplementor(cdspImplementorKeyLegacy);

            Assert.NotNull(cdspImplementor);
            Assert.That(cdspImplementor.CdspImplementorKeyLegacy, Is.EqualTo(cdspImplementorKeyLegacy));
            Assert.That(cdspImplementor.StartDate, Is.EqualTo(new DateTime(2001, 2, 3, 4, 5, 6)));

            restService.VerifyAllExpectations();
        }

        [Test]
        public void GetChildCaseStudy()
        {
            const string childKey = "AB123456";
            var returnedRestObject = new ChildCaseStudyRest { ChildKey = childKey, ChildCaseStudyDate = "2001-02-03T04:05:06-06:00" };

            var restService = MockRepository.GenerateMock<IRestService>();
            restService.Expect(r => r.Get<ChildCaseStudyRest>("children/AB123456/casestudy"))
                .Return(returnedRestObject);

            var gmcRestService = new GmcRestService(restService);
            var childCaseStudy = gmcRestService.GetChildCaseStudy(childKey);

            Assert.NotNull(childCaseStudy);
            Assert.That(childCaseStudy.ChildKey, Is.EqualTo(childKey));
            Assert.That(childCaseStudy.ChildCaseStudyDate, Is.EqualTo(new DateTime(2001, 2, 3, 4, 5, 6)));

            restService.VerifyAllExpectations();
        }

        [Test]
        public void GetChildExitDetails()
        {
            const string childKey = "AB123456";
            var returnedRestObject = new ChildExitDetailsRest { ChildKey = childKey, ExitDate = "2001-02-03T04:05:06-06:00" };

            var restService = MockRepository.GenerateMock<IRestService>();
            restService.Expect(r => r.Get<ChildExitDetailsRest>("children/AB123456/exitdetails"))
                .Return(returnedRestObject);

            var gmcRestService = new GmcRestService(restService);
            var childExitDetails = gmcRestService.GetChildExitDetails(childKey);

            Assert.NotNull(childExitDetails);
            Assert.That(childExitDetails.ChildKey, Is.EqualTo(childKey));
            Assert.That(childExitDetails.ExitDate, Is.EqualTo(new DateTime(2001, 2, 3, 4, 5, 6)));

            restService.VerifyAllExpectations();
        }

        [Test]
        public void GetChildImage_NoOptionalParameters()
        {
            const string childKey = "AB123456";
            var returnedRestObject = new ChildImage();
            IDictionary<string, string> calledParameters = null;

            var restService = MockRepository.GenerateMock<IRestService>();
            restService.Expect(r => r.Get<ChildImage>(Arg<string>.Is.Equal("children/AB123456/image"), Arg<IDictionary<string, string>>.Is.Anything))
                .WhenCalled(m => calledParameters = m.Arguments[1] as IDictionary<string, string>)
                .Return(returnedRestObject);

            var gmcRestService = new GmcRestService(restService);
            var childImage = gmcRestService.GetChildImage(childKey);

            Assert.That(childImage, Is.EqualTo(returnedRestObject));
            Assert.That(calledParameters.Count, Is.EqualTo(0));

            restService.VerifyAllExpectations();
        }

        [Test]
        public void GetChildImage_WithOptionalParameters()
        {
            const string childKey = "AB123456";
            const int height = 123;
            const int width = 456;
            const int dpi = 789;
            const int quality = 951;
            const ChildImageFormat childImageFormat = ChildImageFormat.Jpeg;
            const ChildImageType childImageType = ChildImageType.Headshot;

            var returnedRestObject = new ChildImage();
            IDictionary<string, string> calledParameters = null;

            var restService = MockRepository.GenerateMock<IRestService>();
            restService.Expect(r => r.Get<ChildImage>(Arg<string>.Is.Equal("children/AB123456/image"), Arg<IDictionary<string, string>>.Is.Anything))
                .WhenCalled(m => calledParameters = m.Arguments[1] as IDictionary<string, string>)
                .Return(returnedRestObject);

            var gmcRestService = new GmcRestService(restService);
            var childImage = gmcRestService.GetChildImage(childKey, height, width, dpi, quality, childImageFormat, childImageType);

            Assert.That(childImage, Is.EqualTo(returnedRestObject));
            Assert.That(calledParameters.Count, Is.EqualTo(6));
            Assert.That(calledParameters["height"], Is.EqualTo(height.ToString()));
            Assert.That(calledParameters["width"], Is.EqualTo(width.ToString()));
            Assert.That(calledParameters["dpi"], Is.EqualTo(dpi.ToString()));
            Assert.That(calledParameters["quality"], Is.EqualTo(quality.ToString()));
            Assert.That(calledParameters["imageFormat"], Is.EqualTo(childImageFormat.ToString()));
            Assert.That(calledParameters["imageType"], Is.EqualTo(childImageType.ToString()));

            restService.VerifyAllExpectations();
        }

        [Test]
        public void GetChildInformation()
        {
            const string childKey = "AB123456";
            var returnedRestObject = new ChildRest { ChildKey = childKey, StartDate = "2001-02-03T04:05:06-06:00" };

            var restService = MockRepository.GenerateMock<IRestService>();
            restService.Expect(r => r.Get<ChildRest>("children/AB123456/information"))
                .Return(returnedRestObject);

            var gmcRestService = new GmcRestService(restService);
            var childInformation = gmcRestService.GetChildInformation(childKey);

            Assert.NotNull(childInformation);
            Assert.That(childInformation.ChildKey, Is.EqualTo(childKey));
            Assert.That(childInformation.StartDate, Is.EqualTo(new DateTime(2001, 2, 3, 4, 5, 6)));

            restService.VerifyAllExpectations();
        }

        [Test]
        public void GetCommunity()
        {
            const int communityId = 1234;
            var returnedRestObject = new Community();

            var restService = MockRepository.GenerateMock<IRestService>();
            restService.Expect(r => r.Get<Community>("communities/1234"))
                .Return(returnedRestObject);

            var gmcRestService = new GmcRestService(restService);
            var community = gmcRestService.GetCommunity(communityId);

            Assert.That(community, Is.EqualTo(returnedRestObject));

            restService.VerifyAllExpectations();
        }

        [Test]
        public void GetCountryByIsoNumericCode()
        {
            const int isoCountryNumericCode = 123;
            var returnedRestObject = new Country();

            var restService = MockRepository.GenerateMock<IRestService>();
            restService.Expect(r => r.Get<Country>("countries/123"))
                .Return(returnedRestObject);

            var gmcRestService = new GmcRestService(restService);
            var country = gmcRestService.GetCountryByIsoNumericCode(isoCountryNumericCode);

            Assert.That(country, Is.EqualTo(returnedRestObject));

            restService.VerifyAllExpectations();
        }

        [Test]
        public void GetCountryByIsoAlpha2Code()
        {
            const string isoCountryAlpha2Code = "SV";
            var returnedRestObject = new Country();

            var restService = MockRepository.GenerateMock<IRestService>();
            restService.Expect(r => r.Get<Country>("countries/iso/SV"))
                .Return(returnedRestObject);

            var gmcRestService = new GmcRestService(restService);
            var country = gmcRestService.GetCountryByIsoAlpha2Code(isoCountryAlpha2Code);

            Assert.That(country, Is.EqualTo(returnedRestObject));

            restService.VerifyAllExpectations();
        }

        [Test]
        public void GetCountryByLegacyCompassionCode()
        {
            const string compassionCountryCode = "ES";
            var returnedRestObject = new Country();

            var restService = MockRepository.GenerateMock<IRestService>();
            restService.Expect(r => r.Get<Country>("countries/legacy/ES"))
                .Return(returnedRestObject);

            var gmcRestService = new GmcRestService(restService);
            var country = gmcRestService.GetCountryByLegacyCompassionCode(compassionCountryCode);

            Assert.That(country, Is.EqualTo(returnedRestObject));

            restService.VerifyAllExpectations();
        }

        [Test]
        public void GetCspImplementor()
        {
            const string cspImplementorKeyLegacy = "ABCD1";
            var returnedRestObject = new CspImplementorRest { CspImplementorKeyLegacy = cspImplementorKeyLegacy, StartDate = "2001-02-03T04:05:06-06:00" };

            var restService = MockRepository.GenerateMock<IRestService>();
            restService.Expect(r => r.Get<CspImplementorRest>("cspimplementors/ABCD1"))
                .Return(returnedRestObject);

            var gmcRestService = new GmcRestService(restService);
            var cspImplementor = gmcRestService.GetCspImplementor(cspImplementorKeyLegacy);

            Assert.NotNull(cspImplementor);
            Assert.That(cspImplementor.CspImplementorKeyLegacy, Is.EqualTo(cspImplementorKeyLegacy));
            Assert.That(cspImplementor.StartDate, Is.EqualTo(new DateTime(2001, 2, 3, 4, 5, 6)));

            restService.VerifyAllExpectations();
        }

        [Test]
        public void GetChurchPartner()
        {
            const int localChurchPartnerId = 1234;
            var returnedRestObject = new LocalChurchPartnerRest { LocalChurchPartnerID = localChurchPartnerId, StartDate = "2001-02-03T04:05:06-06:00" };

            var restService = MockRepository.GenerateMock<IRestService>();
            restService.Expect(r => r.Get<LocalChurchPartnerRest>("localchurchpartners/1234"))
                .Return(returnedRestObject);

            var gmcRestService = new GmcRestService(restService);
            var localChurchPartner = gmcRestService.GetLocalChurchPartner(localChurchPartnerId);

            Assert.NotNull(localChurchPartner);
            Assert.That(localChurchPartner.LocalChurchPartnerID, Is.EqualTo(localChurchPartnerId));
            Assert.That(localChurchPartner.StartDate, Is.EqualTo(new DateTime(2001, 2, 3, 4, 5, 6)));

            restService.VerifyAllExpectations();
        }

        [Test]
        public void GetProgramImplementor()
        {
            const string implementorKeyLegacy = "AB123";
            var returnedRestObject = new ProgramImplementorRest { ImplementorKeyLegacy = implementorKeyLegacy, StartDate = "2001-02-03T04:05:06-06:00" };

            var restService = MockRepository.GenerateMock<IRestService>();
            restService.Expect(r => r.Get<ProgramImplementorRest>("programimplementors/AB123"))
                .Return(returnedRestObject);

            var gmcRestService = new GmcRestService(restService);
            var programImplementor = gmcRestService.GetProgramImplementor(implementorKeyLegacy);

            Assert.NotNull(programImplementor);
            Assert.That(programImplementor.ImplementorKeyLegacy, Is.EqualTo(implementorKeyLegacy));
            Assert.That(programImplementor.StartDate, Is.EqualTo(new DateTime(2001, 2, 3, 4, 5, 6)));

            restService.VerifyAllExpectations();
        }

        [Test]
        public void GetProjectAgeGroups()
        {
            const string projectKey = "AB123";
            var returnedRestObject = new ProjectAgeGroups();

            var restService = MockRepository.GenerateMock<IRestService>();
            restService.Expect(r => r.Get<ProjectAgeGroups>("cdspimplementors/AB123/agegroups"))
                .Return(returnedRestObject);

            var gmcRestService = new GmcRestService(restService);
            var projectAgeGroups = gmcRestService.GetProjectAgeGroups(projectKey);

            Assert.NotNull(projectAgeGroups);
            Assert.That(projectAgeGroups, Is.EqualTo(returnedRestObject));

            restService.VerifyAllExpectations();
        }
    }
}