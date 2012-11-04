using System.Linq;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Domain {
    [TestClass]
    public class WhenEnumeratingTree {
        [TestMethod]
        public void CountInEnumeratorsMustMatchCountInTree() {
            var tree = new BinarySearchTree<int, int>();

            tree.Insert(1.AsKeyValue());
            tree.Insert(3.AsKeyValue());
            tree.Insert(2.AsKeyValue());

            Assert.AreEqual(3, tree.BreadthFirstSearchEnumerator().Count());
            Assert.AreEqual(3, tree.DepthFirstSearchEnumerator().Count());
        }

        [TestMethod]
        public void CanEnumerateBreadthFirstSearch() {
            var tree = new BinarySearchTree<int, int>(new[] {3, 2, 1, 2, 4, 3}.AsKeyValueList());

            var expected = new[] {3, 2, 4, 1, 2, 3};
            CollectionAssert.AreEqual(expected, tree.BreadthFirstSearchEnumerator().Select(_ => _.Value).ToList());
        }

        [TestMethod]
        public void CanEnumerateDepthFirstSearch() {
            var tree = new BinarySearchTree<int, int>(new[] {3, 2, 1, 2, 4, 3}.AsKeyValueList());

            var expected = new[] {3, 2, 1, 2, 4, 3};
            CollectionAssert.AreEqual(expected, tree.DepthFirstSearchEnumerator().Select(_ => _.Value).ToList());
        }
    }
}