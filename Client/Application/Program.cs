﻿using System;
using Infrastructure;
using View;
using ViewModel;

namespace Application {
    internal static class Program {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main() {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new MainForm(new MainViewModel(new PlainTextLogger())));
        }
    }
}