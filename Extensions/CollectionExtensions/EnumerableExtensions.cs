using System.Collections.Generic;
using System.Linq;

namespace Extensions.CollectionExtensions
{
    /// <summary>
    /// Provides useful extensions for classes that implement 
    /// <see cref="IEnumerable{T}"/>.
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Whether or not the <see cref="IEnumerable{T}"/> is empty.
        /// </summary>
        public static bool IsEmpty<T>(this IEnumerable<T> enumerable)
        {
            return !enumerable.Any();
        }

        /// <summary>
        /// Whether or not the <see cref="IEnumerable{T}"/> is null or empty.
        /// </summary>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable == null || enumerable.IsEmpty();
        }

        /// <summary>
        /// Whether or not the <see cref="IEnumerable{T}"/> has multiple items.
        /// </summary>
        public static bool Multiple<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.Count() > 1;
        }
    }
}