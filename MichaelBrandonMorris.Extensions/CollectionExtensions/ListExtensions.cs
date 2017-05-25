using System;
using System.Collections.Generic;
using System.Linq;

namespace MichaelBrandonMorris.Extensions.CollectionExtensions
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

        /// <summary>
        /// Returns the shuffled <see cref="IList{T}"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
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
    }
}