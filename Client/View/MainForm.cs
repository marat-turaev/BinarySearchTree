using System;
using System.Windows.Forms;
using ViewModel;

namespace View {
    public partial class MainForm : Form {
        private readonly MainViewModel viewModel;

        public MainForm(MainViewModel viewModel) {
            this.viewModel = viewModel;
            InitializeComponent();

            Bind();
            BindEvents();
        }

        private void BindEvents() {
            AddButton.Click += (s, e) => {
                                   BackBind();
                                   viewModel.Insert();
                               };

            FindButton.Click += (s, e) => {
                                    BackBind();
                                    viewModel.Find();
                                    Bind();
                                };

            HtmlLoggerButton.Click += (s, e) => viewModel.ToHtml();

            PlainTextLoggerButton.Click += (s, e) => viewModel.ToPlainText();
        }

        private void Bind() {
            newKeyTextBox.Text = viewModel.NewKey.ToString();
            newValueTextBox.Text = viewModel.NewValue.ToString();
            findKeyTextBox.Text = viewModel.FindKey.ToString();
            foundValueTextBox.Text = viewModel.FoundValue.ToString();
        }

        private void BackBind() {
            viewModel.NewKey = Convert.ToInt32(newKeyTextBox.Text);
            viewModel.NewValue = Convert.ToInt32(newValueTextBox.Text);
            viewModel.FindKey = Convert.ToInt32(findKeyTextBox.Text);
        }
    }
}