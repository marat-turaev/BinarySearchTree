using System;
using System.Collections.Generic;

namespace Domain {
    internal interface IOrderedSet<TKey, TValue> where TKey : IComparable<TKey> {
        TValue this[TKey key] { get; }
        void Delete(TKey key);
        TValue Minimum { get; }
        TValue Maximum { get; }
        void Insert(KeyValue<TKey, TValue> value);
        TValue Predecessor(TKey key);
        TValue Successor(TKey key);
        IEnumerable<TValue> Sort();
    }
}