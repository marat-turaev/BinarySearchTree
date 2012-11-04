using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Domain {
    [TestClass]
    public class WhenSearchingMaximum {
        [TestMethod]
        public void CanFindMaximumInOneElementTree() {
            var tree = new BinarySearchTree<int, int>();
            tree.Insert(1.AsKeyValue());

            Assert.AreEqual(1, tree.Maximum);
        }

        [TestMethod]
        public void CanFindMaximumInComplexTree() {
            var tree = new BinarySearchTree<int, int>(new[] {6, 3, 10, 2, 1, 5, 9}.AsKeyValueList());

            Assert.AreEqual(10, tree.Maximum);
        }
    }
}