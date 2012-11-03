using System;
using System.Collections.Generic;
using Common;

namespace Domain {
    public class BinarySearchTree<TKey, TValue> : Tree<KeyValue<TKey, TValue>>, IOrderedSet<TKey, TValue>
        where TKey : IComparable<TKey> {
        private Node<KeyValue<TKey, TValue>> root;

        public BinarySearchTree() {}

        public BinarySearchTree(IEnumerable<KeyValue<TKey, TValue>> initalValues) {
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

        public IEnumerable<KeyValue<TKey, TValue>> BreadthFirstSearchEnumerator() {
            var queue = new Queue<Node<KeyValue<TKey, TValue>>>();
            root.Try(queue.Enqueue);

            while (queue.Count != 0) {
                var node = queue.Dequeue();
                yield return node.Item;
                node.Left.Try(queue.Enqueue);
                node.Right.Try(queue.Enqueue);
            }
        }

        public IEnumerable<KeyValue<TKey, TValue>> DepthFirstSearchEnumerator() {
            var stack = new Stack<Node<KeyValue<TKey, TValue>>>();
            root.Try(stack.Push);

            while (stack.Count != 0) {
                var node = stack.Pop();
                yield return node.Item;
                node.Left.Try(stack.Push);
                node.Right.Try(stack.Push);
            }
        }
    }

    public class Tree<T> {}
}