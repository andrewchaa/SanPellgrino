using System.Collections.Generic;
using System.Linq;

namespace SanPellgrino
{
    public static class CollectionExtensions
    {
        public static string ToCsvString<T>(this IEnumerable<T> list)
        {
            return string.Join(",", list);
        }

        public static IEnumerable<int> ToListFromCsv<T>(this string csv)
        {
            return csv.Split(',').Select(int.Parse);
        }
        
        public static bool Empty<T>(this IEnumerable<T> list)
        {
            return !list.Any();
        }

        public static bool IsOneOf<T>(this T element, IEnumerable<T> list)
        {
            return list.Contains(element);
        }

    }
}