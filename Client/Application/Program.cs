using System;
using Infrastructure;
using View;
using ViewModel;
using WpfClient;

namespace Application {
    internal static class Program {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main() {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            var form = new MainForm(new MainViewModel(new PlainTextLogger()));
            System.Windows.Forms.Application.Run(form);
        }
    }
}