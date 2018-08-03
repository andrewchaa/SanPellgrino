using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public static void ForEach<T>(this IEnumerable<T> ls, Action<T> action)
        {
            foreach (var l in ls)
            {
                action(l);
            }
        }

        public static async Task ForEachAsync<T>(this IEnumerable<T> ls, Func<T, Task> action)
        {
            foreach (var l in ls)
            {
                await action(l);
            }
        }

    }
}