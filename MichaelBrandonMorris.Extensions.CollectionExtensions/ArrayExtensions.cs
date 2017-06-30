using System.Linq;

namespace MichaelBrandonMorris.Extensions.CollectionExtensions
{
    /// <summary>
    ///     Class ArrayExtensions.
    /// </summary>
    /// TODO Edit XML Comment Template for ArrayExtensions
    public static class ArrayExtensions
    {
        /// <summary>
        ///     Skips the specified count.
        /// </summary>
        /// <typeparam name="TSource">The type of the t source.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="count">The count.</param>
        /// <returns>TSource[].</returns>
        /// TODO Edit XML Comment Template for Skip`1
        public static TSource[] Skip<TSource>(this TSource[] source, int count)
        {
            return source.AsEnumerable().Skip(count).ToArray();
        }
    }
}