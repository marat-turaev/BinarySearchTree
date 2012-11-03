using System;

namespace Domain {
    internal interface IOrderedSet<TKey, TValue> where TKey : IComparable<TKey> {
        //TODO:
        TValue Search(TKey key);
//        void Delete(TKey key);
        TValue Minimum { get; }
        TValue Maximum { get; }
        void Insert(KeyValue<TKey, TValue> value);
//        TValue Predecessor(TKey key);
//        TValue Successor(TKey key);
    }
}