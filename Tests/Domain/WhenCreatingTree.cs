using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Domain {
    [TestClass]
    public class WhenCreatingTree {
        [TestMethod]
        public void CountOfElemtsIsZero() {
            var tree = new BinarySearchTree<int, int>();
            Assert.AreEqual(0, tree.Count);
        }

        [TestMethod]
        public void TreeCanBeInitializedFromCollection() {
            var initalValues = new[] {1, 2, 3}.AsKeyValueList();
            var tree = new BinarySearchTree<int, int>(initalValues);
            Assert.AreEqual(3, tree.Count);
        }
    }
}