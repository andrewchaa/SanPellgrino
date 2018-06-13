using System;

namespace SanPellgrino
{
    public static class EnumExtensions
    {
        public static T To<T>(this string value) where T : struct
        {
            return Enum.Parse<T>(value, true);
        }

        public static string ToLowerString(this Enum value)
        {
            return value.ToString().ToLower();
        }

        public static bool IsParsable<T>(this string value) where T : struct
        {
            return Enum.TryParse<T>(value, true, out _);
        }
    }
}