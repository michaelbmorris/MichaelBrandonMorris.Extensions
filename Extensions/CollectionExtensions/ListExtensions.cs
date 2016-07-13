using System.Collections.Generic;
using System.Linq;

namespace Extensions.CollectionExtensions
{
    /// <summary>
    /// Provides useful extensions for classes that implement 
    /// <see cref="IList{T}"/>.
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        /// Adds an item to the end of the <see cref="IList{T}"/>.
        /// </summary>
        public static void Push<T>(this IList<T> list, T t)
        {
            list.Add(t);
        }

        /// <summary>
        /// Removes and returns the item from the end of the 
        /// <see cref="IList{T}"/>.
        /// </summary>
        public static T Pop<T>(this IList<T> list)
        {
            var t = list.Last();
            list.Remove(t);
            return t;
        }

        /// <summary>
        /// Returns the item from the end of the <see cref="IList{T}"/>.
        /// </summary>
        public static T Peek<T>(this IList<T> list)
        {
            return list.Any() ?
                list.Last() : default(T);
        }
    }
}