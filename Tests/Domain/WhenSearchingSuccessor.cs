using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Domain {
    [TestClass]
    public class WhenSearchingSuccessor {
        [TestMethod]
        public void CanFindSuccessor() {
            var tree = new BinarySearchTree<int, int>();
            tree.Insert(new KeyValue<int, int>(1, 2));
            tree.Insert(new KeyValue<int, int>(4, 5));
            tree.Insert(new KeyValue<int, int>(2, 7));

            Assert.AreEqual(7, tree.Successor(1));
            Assert.AreEqual(5, tree.Successor(2));
        }
    }
}