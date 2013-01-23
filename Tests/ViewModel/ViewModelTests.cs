using System.Linq;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Fakes;
using ViewModel;

namespace Tests.ViewModel {
    [TestClass]
    public class ViewModelTests {
        private MainViewModel viewModel;
        private FakeLogger logger;

        [TestInitialize]
        public void TestInitialize() {
            logger = new FakeLogger();
            viewModel = new MainViewModel(logger);
        }

        [TestMethod]
        public void TreeIsNotNull() {
            Assert.IsNotNull(viewModel.Tree);
        }

        [TestMethod]
        public void CanAddNewNode() {
            viewModel.NewKey = 1;
            viewModel.NewValue = 2;

            viewModel.Insert();

            Assert.IsTrue(viewModel.Tree.Contains(new KeyValue<int, int>(1, 2)));
        }

        [TestMethod]
        public void CanDeleteElement() {
            viewModel.DeleteKey = 1;

            viewModel.NewKey = 1;
            viewModel.NewValue = 2;
            viewModel.Insert();

            viewModel.Delete();

            Assert.IsFalse(viewModel.Tree.Contains(new KeyValue<int, int>(1, 2)));
        }

        [TestMethod]
        public void CanFindElement() {
            viewModel.FindKey = 1;

            viewModel.NewKey = 1;
            viewModel.NewValue = 2;
            viewModel.Insert();

            viewModel.Find();

            Assert.AreEqual(2, viewModel.FoundValue);
        }

        [TestMethod]
        public void AddingElementWasLogged() {
            viewModel.NewKey = 1;
            viewModel.NewValue = 2;

            viewModel.Insert();

            Assert.IsTrue(viewModel.FullLog.Contains("Added element: 1 - 2"));
        }

        [TestMethod]
        public void ElementDeletionWasLogged() {
            viewModel.DeleteKey = 1;

            viewModel.NewKey = 1;
            viewModel.NewValue = 2;
            viewModel.Insert();

            viewModel.Delete();

            Assert.IsTrue(viewModel.FullLog.Contains("Deleted element with key: 1"));
        }

        [TestMethod]
        public void FindingElemtWasLogged() {
            viewModel.FindKey = 1;

            viewModel.NewKey = 1;
            viewModel.NewValue = 2;
            viewModel.Insert();

            viewModel.Find();

            Assert.IsTrue(viewModel.FullLog.Contains("Found element: 1 - 2"));
        }
    }
}