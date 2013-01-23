using System;
using Domain;
using Infrastructure;

namespace ViewModel {
    public class MainViewModel {
        private Logger logger;

        public MainViewModel(Logger logger) {
            this.logger = logger;
            Tree = new BinarySearchTree<int, int>();
        }

        public readonly BinarySearchTree<int, int> Tree;

        public int NewValue { get; set; }
        public int NewKey { get; set; }

        public int DeleteKey { get; set; }

        public int FindKey { get; set; }
        public int FoundValue { get; private set; }

        public void Insert() {
            Tree.Insert(new KeyValue<int, int>(NewKey, NewValue));
            logger.Log(string.Format("Added element: {0} - {1}", NewKey, NewValue));
        }

        public void Delete() {
            Tree.Delete(DeleteKey);
            logger.Log(string.Format("Deleted element with key: {0}", DeleteKey));
        }

        public void Find() {
            FoundValue = Tree[FindKey];
            logger.Log(string.Format("Found element: {0} - {1}", FindKey, FoundValue));
        }

        public void ToHtml() {
            logger = new HtmlLogger();
        }

        public void ToPlainText() {
            logger = new PlainTextLogger();
        }

        public string FullLog {
            get { return string.Join(Environment.NewLine, logger.Logs); }
        }
    }
}