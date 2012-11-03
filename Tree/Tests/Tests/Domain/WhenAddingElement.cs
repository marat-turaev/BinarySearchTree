using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Domain {
    [TestClass]
    public class WhenAddingElement {
        [TestMethod]
        public void AfterAddingIncreaseCount() {
            var tree = new Tree<int, int>();
            tree.Insert(new KeyValue<int, int>(1, 1));
            Assert.AreEqual(1, tree.Count);
        }
    }
}