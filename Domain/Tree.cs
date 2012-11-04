using System.Collections.Generic;
using Common;

namespace Domain {
    public abstract class Tree<T> {
        protected Node<T> root;

        public IEnumerable<T> DepthFirstSearchEnumerator() {
            var stack = new Stack<Node<T>>();
            root.Try(stack.Push);

            while (stack.Count != 0) {
                var node = stack.Pop();
                yield return node.Item;
                node.Left.Try(stack.Push);
                node.Right.Try(stack.Push);
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
    }
}