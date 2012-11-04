using System.Linq;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Domain {
    [TestClass]
    public class WhenAddingElement {
        [TestMethod]
        public void AfterAddingIncreaseCount() {
            var tree = new BinarySearchTree<int, int>();

            tree.Insert(1.AsKeyValue());
            Assert.AreEqual(1, tree.Count);

            tree.Insert(2.AsKeyValue());
            Assert.AreEqual(2, tree.Count);
        }

        [TestMethod]
        public void AppearInRootAfterAddingFirstElement() {
            var tree = new BinarySearchTree<int, int>();
            var element = 1.AsKeyValue();
            tree.Insert(element);

            Assert.IsTrue(tree.BreadthFirstSearchEnumerator().Contains(element));
            Assert.IsTrue(tree.DepthFirstSearchEnumerator().Contains(element));
        }

        [TestMethod]
        public void AppearInBinarySerachTreeOrder() {
            var tree = new BinarySearchTree<int, int>();
            var element1 = 1.AsKeyValue();
            var element2 = 2.AsKeyValue();
            var element3 = 3.AsKeyValue();
            tree.Insert(element2);
            tree.Insert(element3);
            tree.Insert(element1);

            var elements = tree.BreadthFirstSearchEnumerator();
            Assert.AreEqual(elements.ElementAt(0), element2);
            Assert.AreEqual(elements.ElementAt(1), element1);
            Assert.AreEqual(elements.ElementAt(2), element3);
        }
    }
}