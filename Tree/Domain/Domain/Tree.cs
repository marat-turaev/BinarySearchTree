using System;
using System.Collections.Generic;
using Common;

namespace Domain {
    public class Tree<TKey, TValue> : IOrderedSet<TKey, TValue>
        where TKey : IComparable<TKey> {
        public Tree() {}

        public Tree(IEnumerable<KeyValue<TKey, TValue>> initalValues) {
            initalValues.ForEach(Insert);
        }

        public TValue Search(TKey key) {
            throw new NotImplementedException();
        }

        public void Insert(KeyValue<TKey, TValue> value) {
            throw new NotImplementedException();
        }

        public void Delete(TKey key) {
            throw new NotImplementedException();
        }

        public TValue Maximum() {
            throw new NotImplementedException();
        }

        public TValue Minimum() {
            throw new NotImplementedException();
        }
    }
}