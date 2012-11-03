using System;
using System.Collections.Generic;
using Common;

namespace Domain {
    public class Tree<TKey, TValue> : IOrderedSet<TKey, TValue>
        where TKey : IComparable<TKey> {
        private Node<KeyValue<TKey, TValue>> root;

        public Tree() {}

        public Tree(IEnumerable<KeyValue<TKey, TValue>> initalValues) {
            initalValues.ForEach(Insert);
        }

        public int Count { get; private set; }

        public TValue Search(TKey key) {
            return root.Item.Value;
        }

        public void Insert(KeyValue<TKey, TValue> value) {
            Count++;
            root = new Node<KeyValue<TKey, TValue>>(value);
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