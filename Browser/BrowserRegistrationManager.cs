/********************************************************************++
Copyright (c) Shameel Ahmed.  All rights reserved.
--********************************************************************/

using System;
using System.Reflection;
using Microsoft.Win32;
using System.Security.Permissions;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Drawing;

namespace BrowserSelector {

    internal class BrowserRegistrationManager {

        internal static void RegisterOrUnregisterAsAdmin(bool register) {
            var psi = new ProcessStartInfo();
            psi.FileName = Assembly.GetExecutingAssembly().Location;
            psi.Arguments = register ? "--register" : "--unregister";
            psi.Verb = "runas";

            var process = new Process();
            process.StartInfo = psi;
            process.Start();
            //process.WaitForExit();
        }

        private static BrowserRegistrar GetRegistrar() {
            Version version = Environment.OSVersion.Version;
            OSVersion osVersion = BrowserRegistrar.GetOSVersion(version.Major, version.Minor);
            BrowserRegistrar browserRegistrar = BrowserRegistrar.GetRegistrar(osVersion);
            return browserRegistrar;
        }

        internal static Browser[] GetRegisteredBrowsers() {
            return GetRegistrar().GetRegisteredBrowsers();
        }

        internal static void RegisterBrowser() {
            GetRegistrar().RegisterBrowser();
        }

        internal static void UnregisterBrowser() {
            GetRegistrar().UnregisterBrowser();
        }

        internal static void SetAsDefault() {
            GetRegistrar().SetAsDefault();
        }

        internal static bool IsAppSetAsDefault {
            get {
                return GetRegistrar().IsAppSetAsDefault();
            }
        }
    }

}