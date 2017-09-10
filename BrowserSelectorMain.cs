/********************************************************************++
Copyright (c) Shameel Ahmed.  All rights reserved.
--********************************************************************/

using BrowserSelector.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserSelector {
    static class BrowserSelectorMain {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            try {
                Run(args);
            } catch (Exception ex) {
                HandleMainException(ex);
            }
        }

        static void Run(string[] args) {
            InitializeServices();

            if (args.Length > 0) {
                //If any arguments are passed, handle it and exit.
                //The UI shows only when no arguments are passed.
                HandleArgs(args);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Control.CheckForIllegalCrossThreadCalls = false;

            //Run main form
            MainForm mainForm = MainForm.Instance;
            Application.Run(mainForm);
        }

        static void HandleArgs(string[] args) {
            foreach (string arg in args) {
                if (string.Equals(arg, "--register", StringComparison.OrdinalIgnoreCase)) {
                    BrowserRegistrationManager.RegisterBrowser();
                } else if (string.Equals(arg, "--unregister", StringComparison.OrdinalIgnoreCase)) {
                    BrowserRegistrationManager.UnregisterBrowser();
                /*} else if (arg.StartsWith("http://", StringComparison.OrdinalIgnoreCase)
                          || arg.StartsWith("https://", StringComparison.OrdinalIgnoreCase)
                           arg.StartsWith("ftp://", StringComparison.OrdinalIgnoreCase)) {
                    BrowserManager.LaunchUrl(arg);*/
                } else {
                    BrowserManager.LaunchUrl(arg);
                }
            }
        }

        private static void InitializeServices() {
            string applicationName = Application.ProductName;

            string configDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), applicationName);
            PropertyService.InitializeService(configDirectory, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data"), applicationName);
            PropertyService.Load();

            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
        }

        private static void ShutdownServices() {
            PropertyService.Save();
        }

        static void HandleMainException(Exception ex) {
            MessageBox.Show(ex.ToString(), "Critical error");
        }

        private static void Application_ApplicationExit(object sender, EventArgs e) {
            ShutdownServices();
        }
    }
}
