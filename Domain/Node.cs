using System;

namespace Domain {
    public class Node<T> {
        private Node<T> left;
        private Node<T> right;

        public Node(T item) {
            Item = item;
        }

        public T Item { get; set; }

        public Node<T> Left {
            get { return left; }
            set {
                left = value;
                left.Parent = this;
            }
        }

        public Node<T> Right {
            get { return right; }
            set {
                right = value;
                right.Parent = this;
            }
        }

        public byte ChildrenCount {
            get {
                byte res = 0;
                if (Left != null) res++;
                if (Right != null) res++;
                return res;
            }
        }

        public Node<T> Parent { get; private set; }

        public void DeleteLeftChild() {
            left = null;
        }

        public void DeleteRightChild() {
            right = null;
        }
    }
}