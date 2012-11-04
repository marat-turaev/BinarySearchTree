using System;
using System.Collections.Generic;
using Common;

namespace Domain {
    public class BinarySearchTree<TKey, TValue> : Tree<KeyValue<TKey, TValue>>,
                                                  IOrderedSet<TKey, TValue>
        where TKey : IComparable<TKey> {
        public BinarySearchTree() {}

        public BinarySearchTree(KeyValue<TKey, TValue> initalValue) {
            Insert(initalValue);
        }

        public BinarySearchTree(IEnumerable<KeyValue<TKey, TValue>> initalValues) {
            initalValues.ForEach(Insert);
        }

        public int Count { get; private set; }

        public void Insert(KeyValue<TKey, TValue> value) {
            if (Count == 0) {
                root = new Node<KeyValue<TKey, TValue>>(value);
            } else {
                Insert(root, value);
            }
            Count++;
        }

        public TValue Predecessor(TKey key) {
            var node = Find(root, key);
            if (node.Left != null) return FindMax(node.Left).Item.Value;
            //todo: go to parent
            throw new NotImplementedException();
        }

        public TValue Successor(TKey key) {
            var node = Find(root, key);
            if (node.Right != null) return FindMin(node.Right).Item.Value;
            //todo: go to parent
            throw new NotImplementedException();
        }

        public TValue Search(TKey key) {
            return Find(root, key).Item.Value;
        }

        public TValue Minimum {
            get { return FindMin(root).Item.Value; }
        }

        public TValue Maximum {
            get { return FindMax(root).Item.Value; }
        }

        private static Node<KeyValue<TKey, TValue>> Find(Node<KeyValue<TKey, TValue>> node, TKey key) {
            if (node.Item.Key.Equals(key)) {
                return node;
            }
            if (node.Item.Key.CompareTo(key) < 0) {
                return Find(node.Right, key);
            }
            return Find(node.Left, key);
        }

        private static Node<KeyValue<TKey, TValue>> FindMax(Node<KeyValue<TKey, TValue>> node) {
            return node.Right == null ? node : FindMax(node.Right);
        }

        private static Node<KeyValue<TKey, TValue>> FindMin(Node<KeyValue<TKey, TValue>> node) {
            return node.Left == null ? node : FindMin(node.Left);
        }

        private static void Insert(Node<KeyValue<TKey, TValue>> node, KeyValue<TKey, TValue> value) {
            if (node.Item.Key.CompareTo(value.Key) < 0) {
                if (node.Right == null) {
                    node.Right = new Node<KeyValue<TKey, TValue>>(value);
                    return;
                }
                Insert(node.Right, value);
            } else {
                if (node.Left == null) {
                    node.Left = new Node<KeyValue<TKey, TValue>>(value);
                    return;
                }
                Insert(node.Left, value);
            }
        }
    }
}