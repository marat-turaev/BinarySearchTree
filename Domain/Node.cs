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

        public Node<T> Parent { get; private set; }
    }
}