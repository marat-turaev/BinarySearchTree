using System;
using System.Collections.Generic;
using Common;

namespace Domain {
    public class BinarySearchTree<TKey, TValue> : BinaryTree<KeyValue<TKey, TValue>>, IOrderedSet<TKey, TValue>
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
            return FindLeafPredecessor(node).Item.Value;
        }

        public TValue Successor(TKey key) {
            var node = Find(root, key);
            if (node.Right != null) return FindMin(node.Right).Item.Value;
            return FindLeafSuccessor(node).Item.Value;
        }

        public TValue Search(TKey key) {
            return Find(root, key).Item.Value;
        }

        public void Delete(TKey key) {
            var node = Find(root, key);
            if (node == root) {
                DeleteRoot();
            } else {
                Delete(node);
            }
            Count--;
        }

        public TValue Minimum {
            get { return FindMin(root).Item.Value; }
        }

        public TValue Maximum {
            get { return FindMax(root).Item.Value; }
        }

        private static Node<KeyValue<TKey, TValue>> FindLeafPredecessor(Node<KeyValue<TKey, TValue>> node) {
            while (node.Parent != null && node.Parent.Right != node) {
                node = node.Parent;
            }
            return node.Parent;
        }

        private static Node<KeyValue<TKey, TValue>> FindLeafSuccessor(Node<KeyValue<TKey, TValue>> node) {
            while (node.Parent != null && node.Parent.Left != node) {
                node = node.Parent;
            }
            return node.Parent;
        }

        private void DeleteRoot() {
            switch (root.ChildrenCount) {
                case 0: {
                    root = null;
                    break;
                }
                case 1: {
                    root = root.Left ?? root.Right;
                    break;
                }
                case 2: {
                    var min = FindMin(root.Right);
                    root.Item = min.Item;
                    Delete(min);
                    break;
                }
            }
        }

        private static void Delete(Node<KeyValue<TKey, TValue>> node) {
            var parent = node.Parent;
            switch (node.ChildrenCount) {
                case 0: {
                    if (parent.Left == node) {
                        parent.DeleteLeftChild();
                    }
                    if (parent.Right == node) {
                        parent.DeleteRightChild();
                    }
                    break;
                }
                case 1: {
                    if (parent.Left == node) {
                        parent.Left = node.Left ?? node.Right;
                    }
                    if (parent.Right == node) {
                        parent.Right = node.Left ?? node.Right;
                    }
                    break;
                }
                case 2: {
                    var min = FindMin(node.Right);
                    node.Item = min.Item;
                    Delete(min);
                    break;
                }
            }
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
            if (node.Item.Key.CompareTo(value.Key) <= 0) {
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