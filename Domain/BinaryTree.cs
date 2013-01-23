using System;
using System.Collections;
using System.Collections.Generic;
using Common;

namespace Domain {
    public abstract class BinaryTree<T> : IEnumerable<T> {
        protected Node<T> root;

        public IEnumerable<T> DepthFirstSearchEnumerator() {
            var stack = new Stack<Node<T>>();
            root.Try(stack.Push);

            while (stack.Count != 0) {
                var node = stack.Pop();
                yield return node.Item;
                node.Right.Try(stack.Push);
                node.Left.Try(stack.Push);
            }
        }

        public IEnumerable<T> BreadthFirstSearchEnumerator() {
            var queue = new Queue<Node<T>>();
            root.Try(queue.Enqueue);

            while (queue.Count != 0) {
                var node = queue.Dequeue();
                yield return node.Item;
                node.Left.Try(queue.Enqueue);
                node.Right.Try(queue.Enqueue);
            }
        }

        protected static void InfixTraverse(Node<T> node, Action<Node<T>> visitor) {
            if (node.Left != null) {
                InfixTraverse(node.Left, visitor);
            }
            visitor(node);
            if (node.Right != null) {
                InfixTraverse(node.Right, visitor);
            }
        }

        public IEnumerator<T> GetEnumerator() {
            return BreadthFirstSearchEnumerator().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}