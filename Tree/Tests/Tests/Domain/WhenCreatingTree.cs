using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Domain {
    [TestClass]
    public class WhenCreatingTree {
        [TestMethod]
        public void EmptyTreeCanBeInitialized() {
            new Tree<int, int>();
        }

        [TestMethod]
        public void TreeCanBeInitializedFromCollection() {
            var initalValues = new[] {1, 2, 3}.AsKeyValueList();
            new Tree<int, int>(initalValues);
        }
    }
}