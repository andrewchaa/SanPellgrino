using System.Collections.Generic;
using Newtonsoft.Json;

namespace SanPellgrino
{
    public static class CollectionExtensions
    {
        public static string ToCsvString<T>(this IEnumerable<T> list)
        {
            return string.Join(",", list);
        }

        public static string ToJson<T>(this IList<T> list)
        {
            return JsonConvert.SerializeObject(list);
        }
    }
}