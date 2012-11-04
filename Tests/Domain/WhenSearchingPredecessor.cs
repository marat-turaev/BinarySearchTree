using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Domain {
    [TestClass]
    public class WhenSearchinPredecessor {
        [TestMethod]
        public void CanFindSuccessor() {
            var tree = new BinarySearchTree<int, int>();
            tree.Insert(new KeyValue<int, int>(1, 2));
            tree.Insert(new KeyValue<int, int>(3, 5));
            tree.Insert(new KeyValue<int, int>(2, 7));

            Assert.AreEqual(2, tree.Predecessor(2));
            Assert.AreEqual(7, tree.Predecessor(3));
        }
    }
}