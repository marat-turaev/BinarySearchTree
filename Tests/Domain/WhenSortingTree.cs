using System.Linq;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Domain {
    [TestClass]
    public class WhenSortingTree {
        [TestMethod]
        public void CanSortComplexTree() {
            var tree = new BinarySearchTree<int, int>(new[] {5, 4, 6, 3, 8, 9, 1, 0, 2, 7}.AsKeyValueList());

            CollectionAssert.AreEqual(new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}, tree.Sort().ToList());
        }
    }
}