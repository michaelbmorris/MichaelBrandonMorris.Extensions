using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using MichaelBrandonMorris.Extensions.PrimitiveExtensions;

namespace MichaelBrandonMorris.Extensions.CollectionExtensions
{
    /// <summary>
    ///     Provides useful extensions for classes that implement
    ///     <see cref="IEnumerable{T}" />.
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        ///     Whether or not the <see cref="IEnumerable{String}" /> contains the
        ///     specified string, ignoring case.
        /// </summary>
        /// <param name="strings"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool ContainsIgnoreCase(
            this IEnumerable<string> strings,
            string s)
        {
            return strings.Any(str => str.EqualsOrdinalIgnoreCase(s));
        }

        /// <summary>
        ///     Whether or not the <see cref="IEnumerable{T}" /> is empty.
        /// </summary>
        public static bool IsEmpty<T>(this IEnumerable<T> enumerable)
        {
            return !enumerable.Any();
        }

        /// <summary>
        ///     Whether or not the <see cref="IEnumerable{T}" /> is null or empty.
        /// </summary>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable == null || enumerable.IsEmpty();
        }

        /// <summary>
        ///     Whether or not the <see cref="IEnumerable{T}" /> has multiple items.
        /// </summary>
        public static bool Multiple<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.Count() > 1;
        }

        /// <summary>
        ///     Shuffles the <see cref="IEnumerable{T}" />
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable"></param>
        /// <returns></returns>
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
        ///     Shuffles the <see cref="IEnumerable{T}" /> and returns it as a 
        ///     list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable"></param>
        /// <returns></returns>
        public static IList<T> ShuffleToList<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.Shuffle().ToList();
        }

        /// <summary>
        ///     Converts this <see cref="IEnumerable{ExpandoObject}" /> to a
        ///     <see cref="DataTable" />.
        /// </summary>
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
    }
}