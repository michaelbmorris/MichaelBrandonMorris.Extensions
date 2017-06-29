using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using MichaelBrandonMorris.Extensions.PrimitiveExtensions;

namespace MichaelBrandonMorris.Extensions.CollectionExtensions
{
    /// <summary>
    ///     Class EnumerableExtensions.
    /// </summary>
    /// TODO Edit XML Comment Template for EnumerableExtensions
    public static class EnumerableExtensions
    {
        /// <summary>
        ///     Determines whether [contains ignore case] [the
        ///     specified s].
        /// </summary>
        /// <param name="strings">The strings.</param>
        /// <param name="s">The s.</param>
        /// <returns>
        ///     <c>true</c> if [contains ignore case] [the specified
        ///     s]; otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for ContainsIgnoreCase
        public static bool ContainsIgnoreCase(
            this IEnumerable<string> strings,
            string s)
        {
            return strings.Any(str => str.EqualsOrdinalIgnoreCase(s));
        }

        /// <summary>
        ///     Determines whether the specified enumerable is empty.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <returns>
        ///     <c>true</c> if the specified enumerable is empty;
        ///     otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsEmpty`1
        public static bool IsEmpty<T>(this IEnumerable<T> enumerable)
        {
            return !enumerable.Any();
        }

        /// <summary>
        ///     Determines whether [is null or empty] [the specified
        ///     enumerable].
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <returns>
        ///     <c>true</c> if [is null or empty] [the specified
        ///     enumerable]; otherwise, <c>false</c>.
        /// </returns>
        /// TODO Edit XML Comment Template for IsNullOrEmpty`1
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable == null || enumerable.IsEmpty();
        }

        /// <summary>
        ///     Multiples the specified enumerable.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// TODO Edit XML Comment Template for Multiple`1
        public static bool Multiple<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.Count() > 1;
        }

        /// <summary>
        ///     Orders the by descending where.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objects">The objects.</param>
        /// <param name="orderByPredicate">The order by predicate.</param>
        /// <param name="wherePredicate">The where predicate.</param>
        /// <returns>IList&lt;T&gt;.</returns>
        /// TODO Edit XML Comment Template for OrderByDescendingWhere`1
        public static IList<T> OrderByDescendingWhere<T>(
            this IEnumerable<T> objects,
            Func<T, object> orderByPredicate = null,
            Func<T, bool> wherePredicate = null)
        {
            objects = orderByPredicate == null
                ? objects
                : objects.OrderByDescending(orderByPredicate);

            objects = wherePredicate == null
                ? objects
                : objects.Where(wherePredicate);

            return objects.ToList();
        }

        /// <summary>
        ///     Orders the by where.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objects">The objects.</param>
        /// <param name="orderByPredicate">The order by predicate.</param>
        /// <param name="wherePredicate">The where predicate.</param>
        /// <returns>IList&lt;T&gt;.</returns>
        /// TODO Edit XML Comment Template for OrderByWhere`1
        public static IList<T> OrderByWhere<T>(
            this IEnumerable<T> objects,
            Func<T, object> orderByPredicate = null,
            Func<T, bool> wherePredicate = null)
        {
            objects = orderByPredicate == null
                ? objects
                : objects.OrderBy(orderByPredicate);

            objects = wherePredicate == null
                ? objects
                : objects.Where(wherePredicate);

            return objects.ToList();
        }

        /// <summary>
        ///     Shuffles the specified enumerable.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        /// TODO Edit XML Comment Template for Shuffle`1
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> enumerable)
        {
            var random = new Random();
            var elements = enumerable.ToArray();

            for (var i = elements.Length - 1; i >= 0; i--)
            {
                var swapIndex = random.Next(i + 1);
                yield return elements[swapIndex];

                elements[swapIndex] = elements[i];
            }
        }

        /// <summary>
        ///     Shuffles to list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <returns>IList&lt;T&gt;.</returns>
        /// TODO Edit XML Comment Template for ShuffleToList`1
        public static IList<T> ShuffleToList<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.Shuffle().ToList();
        }

        /// <summary>
        ///     To the data table.
        /// </summary>
        /// <param name="expandoObjectEnumerable">
        ///     The expando object
        ///     enumerable.
        /// </param>
        /// <returns>DataTable.</returns>
        /// TODO Edit XML Comment Template for ToDataTable
        public static DataTable ToDataTable(
            this IEnumerable<ExpandoObject> expandoObjectEnumerable)
        {
            var expandoObjectArray = expandoObjectEnumerable as ExpandoObject[]
                                     ?? expandoObjectEnumerable.ToArray();

            if (expandoObjectArray.IsNullOrEmpty())
            {
                return null;
            }

            var dataTable = new DataTable();

            var firstExpandoObjectAsDictionary =
                (IDictionary<string, object>) expandoObjectArray.First();

            var keys = firstExpandoObjectAsDictionary.Keys;

            foreach (var key in keys)
            {
                dataTable.Columns.Add(key);
            }

            foreach (var expandoObject in expandoObjectArray)
            {
                var expandoObjectAsDictionary =
                    (IDictionary<string, object>) expandoObject;

                var expandoObjectValuesAsArray =
                    expandoObjectAsDictionary.Values.ToArray();

                dataTable.Rows.Add(expandoObjectValuesAsArray);
            }

            return dataTable;
        }
    }
}