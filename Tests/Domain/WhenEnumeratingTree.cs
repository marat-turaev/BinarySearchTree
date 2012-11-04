using System.Linq;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Domain {
    [TestClass]
    public class WhenEnumeratingTree {
        [TestMethod]
        public void CountMustMatchCountInTree() {
            var tree = new BinarySearchTree<int, int>();

            tree.Insert(1.AsKeyValue());
            tree.Insert(3.AsKeyValue());
            tree.Insert(2.AsKeyValue());

            Assert.AreEqual(3, tree.BreadthFirstSearchEnumerator().Count());
            Assert.AreEqual(3, tree.DepthFirstSearchEnumerator().Count());
        }
    }
}