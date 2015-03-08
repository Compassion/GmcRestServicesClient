using System;
using AutoMapper;
using GmcRestServicesClient.AutoMapper;
using NUnit.Framework;

namespace GmcRestServicesClient.Tests
{
    [TestFixture]
    public class DateConverterTests
    {
        [Test]
        public void Iso8601Date_NoMilliseconds_TimezoneStripped()
        {
            const string dateString = "2012-05-04T01:02:03-06:00";
            var resolutionContext = new ResolutionContext(null, dateString, null, null, null, null);
            ITypeConverter<string, DateTime> dateConverter = new DateConverter();
            var dateTime = dateConverter.Convert(resolutionContext);

            Assert.That(dateTime.Year, Is.EqualTo(2012));
            Assert.That(dateTime.Month, Is.EqualTo(5));
            Assert.That(dateTime.Day, Is.EqualTo(4));
            Assert.That(dateTime.Hour, Is.EqualTo(1));
            Assert.That(dateTime.Minute, Is.EqualTo(2));
            Assert.That(dateTime.Second, Is.EqualTo(3));
            Assert.That(dateTime.Millisecond, Is.EqualTo(0));
            Assert.That(dateTime.Kind, Is.EqualTo(DateTimeKind.Unspecified));
        }

        [Test]
        public void Iso8601Date_WithMilliseconds_TimezoneStripped()
        {
            const string dateString = "2012-05-04T01:02:03.700-06:00";
            var resolutionContext = new ResolutionContext(null, dateString, null, null, null, null);
            ITypeConverter<string, DateTime> dateConverter = new DateConverter();
            var dateTime = dateConverter.Convert(resolutionContext);

            Assert.That(dateTime.Year, Is.EqualTo(2012));
            Assert.That(dateTime.Month, Is.EqualTo(5));
            Assert.That(dateTime.Day, Is.EqualTo(4));
            Assert.That(dateTime.Hour, Is.EqualTo(1));
            Assert.That(dateTime.Minute, Is.EqualTo(2));
            Assert.That(dateTime.Second, Is.EqualTo(3));
            Assert.That(dateTime.Millisecond, Is.EqualTo(700));
            Assert.That(dateTime.Kind, Is.EqualTo(DateTimeKind.Unspecified));
        }

        [Test]
        public void SimpleDate()
        {
            const string dateString = "20120304";
            var resolutionContext = new ResolutionContext(null, dateString, null, null, null, null);
            ITypeConverter<string, DateTime> dateConverter = new DateConverter();
            var dateTime = dateConverter.Convert(resolutionContext);

            Assert.That(dateTime.Year, Is.EqualTo(2012));
            Assert.That(dateTime.Month, Is.EqualTo(3));
            Assert.That(dateTime.Day, Is.EqualTo(4));
        }

        [Test]
        public void EmptyDate_ReturnDefaultDate()
        {
            const string dateString = "";
            var resolutionContext = new ResolutionContext(null, dateString, null, null, null, null);
            ITypeConverter<string, DateTime> dateConverter = new DateConverter();
            var dateTime = dateConverter.Convert(resolutionContext);

            Assert.That(dateTime, Is.EqualTo(default(DateTime)));
        }

        [Test]
        public void NullDate_ReturnDefaultDate()
        {
            const string dateString = null;
            var resolutionContext = new ResolutionContext(null, dateString, null, null, null, null);
            ITypeConverter<string, DateTime> dateConverter = new DateConverter();
            var dateTime = dateConverter.Convert(resolutionContext);

            Assert.That(dateTime, Is.EqualTo(default(DateTime)));
        }

        [Test]
        public void EmptyDate_Nullable_ReturnDefaultDate()
        {
            const string dateString = "";
            var resolutionContext = new ResolutionContext(null, dateString, null, null, null, null);
            ITypeConverter<string, DateTime?> dateConverter = new DateConverter();
            var dateTime = dateConverter.Convert(resolutionContext);

            Assert.That(dateTime, Is.EqualTo(null));
        }

        [Test]
        public void NullDate_Nullable_ReturnDefaultDate()
        {
            const string dateString = null;
            var resolutionContext = new ResolutionContext(null, dateString, null, null, null, null);
            ITypeConverter<string, DateTime?> dateConverter = new DateConverter();
            var dateTime = dateConverter.Convert(resolutionContext);

            Assert.That(dateTime, Is.EqualTo(null));
        }
    }
}