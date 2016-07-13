using System.Collections.Generic;
using System.Linq;

namespace CollectionExtensions
{
    public static class ListExtensions
    {
        public static void Push<T>(this List<T> list, T t)
        {
            list.Add(t);
        }

        public static T Pop<T>(this List<T> list)
        {
            var t = list.Last();
            list.Remove(t);
            return t;
        }

        public static bool IsEmpty<T>(this List<T> list)
        {
            return !list.Any();
        }

        public static bool IsNullOrEmpty<T>(this List<T> list)
        {
            return list == null || list.IsEmpty();
        }
    }
}
