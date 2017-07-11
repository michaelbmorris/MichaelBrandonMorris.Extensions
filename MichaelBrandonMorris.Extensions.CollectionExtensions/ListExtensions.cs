using System;
using System.Collections.Generic;
using System.Linq;

namespace MichaelBrandonMorris.Extensions.CollectionExtensions
{
    /// <summary>
    ///     Class ListExtensions.
    /// </summary>
    /// TODO Edit XML Comment Template for ListExtensions
    public static class ListExtensions
    {
        /// <summary>
        ///     Appends the specified list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item">The item.</param>
        /// <param name="list">The list.</param>
        /// <returns>IList&lt;T&gt;.</returns>
        /// TODO Edit XML Comment Template for Append`1
        public static IList<T> Append<T>(this T item, IList<T> list)
        {
            list.Insert(0, item);
            return list;
        }

        /// <summary>
        ///     Inserts the specified index.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <param name="index">The index.</param>
        /// <param name="item">The item.</param>
        /// <returns>IList&lt;T&gt;.</returns>
        /// TODO Edit XML Comment Template for Insert`1
        public static IList<T> Insert<T>(this IList<T> list, int index, T item)
        {
            list.Insert(index, item);
            return list;
        }

        /// <summary>
        ///     Orders the by.
        /// </summary>
        /// <typeparam name="TSource">The type of the t source.</typeparam>
        /// <typeparam name="TKey">The type of the t key.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="keySelector">The key selector.</param>
        /// <param name="comparer">The comparer.</param>
        /// <returns>IList&lt;TSource&gt;.</returns>
        /// TODO Edit XML Comment Template for OrderBy`2
        public static IList<TSource> OrderBy<TSource, TKey>(
            this IList<TSource> source,
            Func<TSource, TKey> keySelector,
            IComparer<TKey> comparer = null)
        {
            if (comparer == null)
            {
                return source.AsEnumerable().OrderBy(keySelector).ToList();
            }

            return source.AsEnumerable()
                .OrderBy(keySelector, comparer)
                .ToList();
        }

        /// <summary>
        ///     Orders the by descending.
        /// </summary>
        /// <typeparam name="TSource">The type of the t source.</typeparam>
        /// <typeparam name="TKey">The type of the t key.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="keySelector">The key selector.</param>
        /// <param name="comparer">The comparer.</param>
        /// <returns>IList&lt;TSource&gt;.</returns>
        /// TODO Edit XML Comment Template for OrderByDescending`2
        public static IList<TSource> OrderByDescending<TSource, TKey>(
            this IList<TSource> source,
            Func<TSource, TKey> keySelector,
            IComparer<TKey> comparer = null)
        {
            IEnumerable<TSource> result =
                comparer == null
                    ? source.AsEnumerable().OrderByDescending(keySelector)
                    : source.AsEnumerable()
                        .OrderByDescending(keySelector, comparer);

            return result.ToList();
        }

        /// <summary>
        ///     Peeks the specified list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <returns>T.</returns>
        /// TODO Edit XML Comment Template for Peek`1
        public static T Peek<T>(this IList<T> list)
        {
            return list.Any() ? list.Last() : default(T);
        }

        /// <summary>
        ///     Pops the specified list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <returns>T.</returns>
        /// TODO Edit XML Comment Template for Pop`1
        public static T Pop<T>(this IList<T> list)
        {
            var t = list.Last();
            list.Remove(t);
            return t;
        }

        /// <summary>
        ///     Prepends the specified item.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <param name="item">The item.</param>
        /// <returns>IList&lt;T&gt;.</returns>
        /// TODO Edit XML Comment Template for Prepend`1
        public static IList<T> Prepend<T>(this IList<T> list, T item)
        {
            list.Insert(0, item);
            return list;
        }

        /// <summary>
        ///     Pushes the specified t.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <param name="t">The t.</param>
        /// TODO Edit XML Comment Template for Push`1
        public static void Push<T>(this IList<T> list, T t)
        {
            list.Add(t);
        }

        /// <summary>
        ///     Selects the specified selector.
        /// </summary>
        /// <typeparam name="TSource">The type of the t source.</typeparam>
        /// <typeparam name="TResult">The type of the t result.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="selector">The selector.</param>
        /// <returns>IList&lt;TResult&gt;.</returns>
        /// TODO Edit XML Comment Template for Select`2
        public static IList<TResult> Select<TSource, TResult>(
            this IList<TSource> source,
            Func<TSource, TResult> selector)
        {
            return source.AsEnumerable().Select(selector).ToList();
        }

        /// <summary>
        ///     Selects the many.
        /// </summary>
        /// <typeparam name="TSource">The type of the t source.</typeparam>
        /// <typeparam name="TResult">The type of the t result.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="selector">The selector.</param>
        /// <returns>IList&lt;TResult&gt;.</returns>
        /// TODO Edit XML Comment Template for SelectMany`2
        public static IList<TResult> SelectMany<TSource, TResult>(
            this IList<TSource> source,
            Func<TSource, IEnumerable<TResult>> selector)
        {
            return source.AsEnumerable().SelectMany(selector).ToList();
        }

        /// <summary>
        ///     Shuffles the specified list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <returns>IList&lt;T&gt;.</returns>
        /// TODO Edit XML Comment Template for Shuffle`1
        public static IList<T> Shuffle<T>(this IList<T> list)
        {
            var random = new Random();
            var n = list.Count;

            for (var i = 0; i < n - 2; i++)
            {
                var j = random.Next(i, n);
                var temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }

            return list;
        }

        /// <summary>
        ///     Takes the specified count.
        /// </summary>
        /// <typeparam name="TSource">The type of the t source.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="count">The count.</param>
        /// <returns>IList&lt;TSource&gt;.</returns>
        /// TODO Edit XML Comment Template for Take`1
        public static IList<TSource> Take
            <TSource>(this IList<TSource> source, int count)
        {
            return source.AsEnumerable().Take(count).ToList();
        }

        /// <summary>
        ///     Wheres the specified predicate.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The list.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>IList&lt;T&gt;.</returns>
        /// TODO Edit XML Comment Template for Where`1
        public static IList<T> Where<T>(
            this IList<T> list,
            Func<T, bool> predicate)
        {
            return list.AsEnumerable().Where(predicate).ToList();
        }
    }
}