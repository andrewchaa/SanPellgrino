using System;
using System.Globalization;
using FunctionalWay.Extensions;

namespace SanPellgrino
{
    public static class DateTimeExtensions
    {
        public static string ToIsoMicroseconds(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd HH:mm:ss.ffffff", CultureInfo.InvariantCulture);
        }
        public static string ToIsoMicrosecondsOffset(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd HH:mm:ss.ffffffzzz", CultureInfo.InvariantCulture);
        }

        public static DateTime ToUnspecified(this DateTime dateTime)
        {
            return dateTime.Map(d => DateTime.SpecifyKind(d, DateTimeKind.Unspecified));
        }

        public static TimeSpan Seconds(this int second)
        {
            return TimeSpan.FromSeconds(second);
        }

        public static DateTime TrimToSeconds(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second);
        }
    }
}