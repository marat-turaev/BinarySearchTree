using System.Linq;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Domain {
    [TestClass]
    public class WhenDeletingNode {
        [TestMethod]
        public void CanDeleteFromRoot() {
            var tree = new BinarySearchTree<int, int>();
            tree.Insert(1.AsKeyValue());

            tree.Delete(1);

            Assert.AreEqual(0, tree.Count);
        }

        [TestMethod]
        public void CanDeleteFromRootWithTwoChildren() {
            var tree = new BinarySearchTree<int, int>();
            tree.Insert(2.AsKeyValue());
            tree.Insert(1.AsKeyValue());
            tree.Insert(3.AsKeyValue());

            tree.Delete(2);

            Assert.AreEqual(2, tree.Count);
        }

        [TestMethod]
        public void CanDeleteFromRootWithRightChild() {
            var tree = new BinarySearchTree<int, int>();
            tree.Insert(1.AsKeyValue());
            tree.Insert(2.AsKeyValue());
            tree.Insert(3.AsKeyValue());

            tree.Delete(1);

            CollectionAssert.AreEqual(new[] {2, 3}, tree.BreadthFirstSearchEnumerator().Select(_ => _.Value).ToList());
        }

        [TestMethod]
        public void CanDeleteFromRootWithLeftChild() {
            var tree = new BinarySearchTree<int, int>();
            tree.Insert(2.AsKeyValue());
            tree.Insert(1.AsKeyValue());
            tree.Insert(3.AsKeyValue());

            tree.Delete(2);

            CollectionAssert.AreEqual(new[] {3, 1}, tree.BreadthFirstSearchEnumerator().Select(_ => _.Value).ToList());
        }

        [TestMethod]
        public void CountMustBeDecreased() {
            var tree = new BinarySearchTree<int, int>();
            tree.Insert(1.AsKeyValue());
            tree.Insert(2.AsKeyValue());
            tree.Insert(3.AsKeyValue());

            tree.Delete(1);

            Assert.AreEqual(2, tree.Count);
        }

        [TestMethod]
        public void CanDeleteFromRightLeaf() {
            var tree = new BinarySearchTree<int, int>();
            tree.Insert(1.AsKeyValue());
            tree.Insert(2.AsKeyValue());
            tree.Insert(3.AsKeyValue());

            tree.Delete(3);

            CollectionAssert.AreEqual(new[] {1, 2}, tree.BreadthFirstSearchEnumerator().Select(_ => _.Value).ToList());
        }

        [TestMethod]
        public void CanDeleteFromLeftLeaf() {
            var tree = new BinarySearchTree<int, int>();
            tree.Insert(3.AsKeyValue());
            tree.Insert(2.AsKeyValue());
            tree.Insert(1.AsKeyValue());

            tree.Delete(1);

            CollectionAssert.AreEqual(new[] {3, 2}, tree.BreadthFirstSearchEnumerator().Select(_ => _.Value).ToList());
        }

        [TestMethod]
        public void CanDeleteFromMiddleWithRightChild() {
            var tree = new BinarySearchTree<int, int>();
            tree.Insert(1.AsKeyValue());
            tree.Insert(2.AsKeyValue());
            tree.Insert(3.AsKeyValue());

            tree.Delete(2);

            CollectionAssert.AreEqual(new[] {1, 3}, tree.BreadthFirstSearchEnumerator().Select(_ => _.Value).ToList());
        }

        [TestMethod]
        public void CanDeleteFromMiddleWithLeftChild() {
            var tree = new BinarySearchTree<int, int>();
            tree.Insert(3.AsKeyValue());
            tree.Insert(2.AsKeyValue());
            tree.Insert(1.AsKeyValue());

            tree.Delete(2);

            CollectionAssert.AreEqual(new[] {3, 1}, tree.BreadthFirstSearchEnumerator().Select(_ => _.Value).ToList());
        }

        [TestMethod]
        public void CanDeleteFromMiddleWithTwoChildren() {
            var tree = new BinarySearchTree<int, int>();
            tree.Insert(1.AsKeyValue());
            tree.Insert(3.AsKeyValue());
            tree.Insert(2.AsKeyValue());
            tree.Insert(4.AsKeyValue());

            tree.Delete(3);

            CollectionAssert.AreEqual(new[] {1, 4, 2}, tree.BreadthFirstSearchEnumerator().Select(_ => _.Value).ToList());
        }

        [TestMethod]
        public void CanDeleteFromComplexTree() {
            var tree = new BinarySearchTree<int, int>();
            tree.Insert(2.AsKeyValue());
            tree.Insert(1.AsKeyValue());
            tree.Insert(3.AsKeyValue());
            tree.Insert(4.AsKeyValue());

            tree.Delete(3);

            CollectionAssert.AreEqual(new[] {2, 1, 4}, tree.BreadthFirstSearchEnumerator().Select(_ => _.Value).ToList());
        }
    }
}