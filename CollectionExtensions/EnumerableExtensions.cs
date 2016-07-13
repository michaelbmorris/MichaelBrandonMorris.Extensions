using System.Collections.Generic;
using System.Linq;

namespace CollectionExtensions
{
    public static class EnumerableExtensions
    {
        public static bool IsEmpty<T>(this IEnumerable<T> enumerable)
        {
            return !enumerable.Any();
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable == null || enumerable.IsEmpty();
        }

        public static bool Multiple<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.Count() > 1;
        }
    }
}