using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Domain {
    [TestClass]
    public class WhenSearchingMinimum {
        [TestMethod]
        public void CanFindMinimumInOneElementTree() {
            var tree = new BinarySearchTree<int, int>(1.AsKeyValue());
            
            Assert.AreEqual(1, tree.Minimum);
        }

        [TestMethod]
        public void CanFindMinimumInComplexTree() {
            var tree = new BinarySearchTree<int, int>(new[] {6, 3, 10, 2, 1, 5, 9}.AsKeyValueList());
            
            Assert.AreEqual(1, tree.Minimum);
        }
    }
}