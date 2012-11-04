using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Domain {
    [TestClass]
    public class WhenSearching {
        [TestMethod]
        public void CanFindElementInOneElementTree() {
            var tree = new BinarySearchTree<int, int>();
            tree.Insert(new KeyValue<int, int>(1, 2));

            Assert.AreEqual(2, tree.Search(1));
        }

        [TestMethod]
        public void CanFindElementInComplexTree() {
            var tree = new BinarySearchTree<int, int>();
            tree.Insert(new KeyValue<int, int>(1, 2));
            tree.Insert(new KeyValue<int, int>(3, 5));
            tree.Insert(new KeyValue<int, int>(2, 7));

            Assert.AreEqual(2, tree.Search(1));
            Assert.AreEqual(7, tree.Search(2));
            Assert.AreEqual(5, tree.Search(3));
        }
    }
}