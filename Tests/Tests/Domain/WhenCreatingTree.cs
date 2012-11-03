using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Domain {
    [TestClass]
    public class WhenCreatingTree {
        [TestMethod]
        public void CountOfElemtsIsZero() {
            var tree = new Tree<int, int>();
            Assert.AreEqual(0, tree.Count);
        }

        [TestMethod, Ignore]
        public void TreeCanBeInitializedFromCollection() {
            var initalValues = new[] {1, 2, 3}.AsKeyValueList();
            new Tree<int, int>(initalValues);
        }
    }
}