namespace Domain {
    public class Node<T> {
        public Node(T item) {
            Item = item;
        }

        public T Item { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
    }
}