using System;
using System.Windows;
using Infrastructure;
using ViewModel;

namespace WpfClient {
    public partial class MainWindow : Window {
        private readonly MainViewModel viewModel;

        public MainWindow() {
            viewModel = new MainViewModel(new PlainTextLogger());
            InitializeComponent();

            Bind();
            BindEvents();
        }

        private void BindEvents() {
            AddButton.Click += (s, e) => {
                                   BackBind();
                                   viewModel.Insert();
                                   Bind();
                               };

            FindButton.Click += (s, e) => {
                                    BackBind();
                                    viewModel.Find();
                                    Bind();
                                };
        }

        private void Bind() {
            NewKeyTextBox.Text = viewModel.NewKey.ToString();
            NewValueTextBox.Text = viewModel.NewValue.ToString();
            FindKeyTextBox.Text = viewModel.FindKey.ToString();
            FindValueTextBox.Text = viewModel.FoundValue.ToString();
            LogTextBox.Text = viewModel.FullLog;
        }

        private void BackBind() {
            viewModel.NewKey = Convert.ToInt32(NewKeyTextBox.Text);
            viewModel.NewValue = Convert.ToInt32(NewValueTextBox.Text);
            viewModel.FindKey = Convert.ToInt32(FindKeyTextBox.Text);
        }
    }
}