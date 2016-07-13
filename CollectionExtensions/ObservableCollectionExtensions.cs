﻿using System.Collections.ObjectModel;
using System.Linq;

namespace CollectionExtensions
{
    public static class ObservableCollectionExtensions
    {
        public static void Push<T>(
            this ObservableCollection<T> observableCollection, T t)
        {
            observableCollection.Add(t);
        }

        public static T Pop<T>(
            this ObservableCollection<T> observableCollection)
        {
            var t = observableCollection.Last();
            observableCollection.Remove(t);
            return t;
        }

        public static bool IsEmpty<T>(
            this ObservableCollection<T> observableCollection)
        {
            return !observableCollection.Any();
        }

        public static bool Multiple<T>(
            this ObservableCollection<T> observableCollection)
        {
            return observableCollection.Count > 1;
        }

        public static T Peek<T>(
            this ObservableCollection<T> observableCollection)
        {
            return observableCollection.Any() ? 
                observableCollection.Last() : default(T);
        }
    }
}
