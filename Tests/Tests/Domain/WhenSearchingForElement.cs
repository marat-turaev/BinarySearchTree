using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Domain {
    [TestClass]
    public class WhenSearchingForElement {
        [TestMethod]
        public void CanFindSingleElementInTree() {
            var tree = new Tree<int, int>();
            
            tree.Insert(new KeyValue<int, int>(1, 2));

            Assert.AreEqual(2, tree.Search(1));
        }
    }
}