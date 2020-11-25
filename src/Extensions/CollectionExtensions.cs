using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanPellgrino
{
    public static class CollectionExtensions
    {
        public static string ToCsvString<T>(this IEnumerable<T> list, bool noSpace = false)
        {
            return string.Join(", ", list);
        }

        public static IEnumerable<int> ToListFromCsv(this string csv)
        {
            return string.IsNullOrEmpty(csv) 
                ? new List<int>()
                : csv.Split(',').Select(int.Parse);
        }

        public static IEnumerable<T> ToListFromCsv<T>(this string csv, Func<string, T> func)
        {
            return string.IsNullOrEmpty(csv) 
                ? new List<T>() 
                : csv.Split(',').Select(func);
        }

        public static IEnumerable<T> ToArray<T>(this T element)
        {
            return new[] {element};
        }

        public static bool Empty<T>(this IEnumerable<T> list)
        {
            return !list.Any();
        }

        public static bool IsOneOf<T>(this T element, params T[] list)
        {
            return list.Contains(element);
        }

        public static bool IsNotOneOf<T>(this T element, params T[] list)
        {
            return !list.Contains(element);
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

        public static IEnumerable<TR> DistinctBy<TR, TI>(this IEnumerable<TR> list, Func<TR, TI> keySelector)
        {
            return list
                .GroupBy(keySelector)
                .Select(x => x.First());
        }

    }
}