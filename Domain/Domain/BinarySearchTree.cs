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