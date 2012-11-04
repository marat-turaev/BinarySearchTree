using System;
using System.Collections.Generic;
using Common;

namespace Domain {
    public abstract class BinaryTree<T> {
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

        protected static void Traverse(Node<T> node, Action<Node<T>> visit) {
            if (node.Left != null) {
                Traverse(node.Left, visit);
            }
            visit(node);
            if (node.Right != null) {
                Traverse(node.Right, visit);
            }
        }
    }
}