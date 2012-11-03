﻿using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Domain {
    [TestClass]
    public class WhenAddingElement {
        [TestMethod]
        public void AfterAddingIncreaseCount() {
            var tree = new BinarySearchTree<int, int>();
            tree.Insert(new KeyValue<int, int>(1, 1));
            Assert.AreEqual(1, tree.Count);
        }
    }
}