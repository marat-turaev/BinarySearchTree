using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Domain {
    [TestClass]
    public class WhenSearchingForElement {
        [TestMethod]
        public void CanFindElementInTrivialTree() {
            var tree = new BinarySearchTree<int, int>();

            tree.Insert(new KeyValue<int, int>(1, 2));

            Assert.AreEqual(2, tree.Search(1));
        }

        [TestMethod, Ignore]
        public void CanFindElementInComplexTree() {
            var tree = new BinarySearchTree<int, int>();

            tree.Insert(new KeyValue<int, int>(1, 2));
            tree.Insert(new KeyValue<int, int>(4, 5));

            Assert.AreEqual(2, tree.Search(1));
        }
    }
}