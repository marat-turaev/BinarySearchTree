using System;

namespace Domain {
    internal interface IOrderedSet<TKey, TValue> where TKey : IComparable<TKey> {
        void Insert(KeyValue<TKey, TValue> value);
        //TODO:
//        TValue Search(TKey key);
//        void Delete(TKey key);
//        TValue Maximum();
//        TValue Minimum();
    }
}