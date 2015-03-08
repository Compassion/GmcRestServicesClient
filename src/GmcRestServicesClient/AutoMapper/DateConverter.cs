using System;
using System.Globalization;
using System.Text.RegularExpressions;
using AutoMapper;

namespace GmcRestServicesClient.AutoMapper
{
    public class DateConverter : ITypeConverter<string, DateTime>, ITypeConverter<string, DateTime?>
    {
        DateTime ITypeConverter<string, DateTime>.Convert(ResolutionContext context)
        {
            var source = context.SourceValue as string;
            if (string.IsNullOrWhiteSpace(source))
                return default(DateTime);
            return ParseDate(source);
        }

        DateTime? ITypeConverter<string, DateTime?>.Convert(ResolutionContext context)
        {
            var source = context.SourceValue as string;
            if (string.IsNullOrWhiteSpace(source))
                return null;
            return ParseDate(source);
        }

        private DateTime ParseDate(string dateString)
        {
            //return DateTime.Parse(dateString.Substring(0, 10)); // strip time and timezone info

            var simpleDate = new Regex(@"^\d\d\d\d\d\d\d\d$");
            if (simpleDate.IsMatch(dateString))
                return DateTime.ParseExact(dateString, "yyyyMMdd", CultureInfo.InvariantCulture);

            var iso8601Date = new Regex(@"^\d\d\d\d-\d\d-\d\dT\d\d:\d\d:\d\d(.)?(\d)*-\d\d:\d\d$");
            if (iso8601Date.IsMatch(dateString))
                return DateTime.Parse(dateString.Substring(0, dateString.LastIndexOf('-'))); // strip timezone info
            
            return DateTime.Parse(dateString);
        }
    }
}