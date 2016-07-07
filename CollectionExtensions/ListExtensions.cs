using System.Collections.Generic;
using System.Linq;

namespace CollectionExtensions
{
    public static class ListExtensions
    {
        public static void Push<T>(this List<T> list, T t)
        {
            list.Insert(0, t);
        }

        public static T Pop<T>(this List<T> list)
        {
            var t = list.First();
            list.Remove(t);
            return t;
        }

        public static bool IsEmpty<T>(this List<T> list)
        {
            return !list.Any();
        }
    }
}
