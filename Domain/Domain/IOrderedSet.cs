using System;

namespace Domain {
    internal interface IOrderedSet<TKey, TValue> where TKey : IComparable<TKey> {
        TValue Search(TKey key);
        void Insert(KeyValue<TKey, TValue> value);
        void Delete(TKey key);
        TValue Maximum();
        TValue Minimum();
    }
}