﻿/********************************************************************++
Copyright (c) Shameel Ahmed.  All rights reserved.
--********************************************************************/

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BrowserSelector {

    abstract class BrowserRegistrar {

        protected const string AppId = "BrowserSelector";
        protected const string AppName = "BrowserSelector";
        protected const string AppDescription = "BrowserSelector";
        protected static string AppPath = Assembly.GetExecutingAssembly().Location;
        protected static string AppIcon = AppPath + ",1";
        protected static string AppOpenUrlCommand = AppPath + " \"%1\"";
        protected static string AppReinstallCommand = AppPath + " --register";
        protected const string userChoice = @"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice";

        static bool isAdminMode = false;

        protected static RegistryKey RootKey {
            get {
                return isAdminMode ? Registry.LocalMachine : Registry.CurrentUser;
            }
        }

        internal static OSVersion GetOSVersion(int major, int minor) {
            //OS version info: https://msdn.microsoft.com/library/windows/desktop/ms724832.aspx
            if ((major == 10)) { 
                return OSVersion.Win10;
            } else if ((major == 6 && minor >= 2)) {
                return OSVersion.Win8;
            } else if (major == 6 && minor == 1) {
                return OSVersion.Win7;
            } else {
                return OSVersion.Unknown;
            }
        }

        internal static BrowserRegistrar GetRegistrar(OSVersion osVersion) {
            switch(osVersion) {
                case OSVersion.Win7:
                    return new BrowserRegistrarWin7();
                case OSVersion.Win8:
                    return new BrowserRegistrarWin10();
                case OSVersion.Win10:
                    return new BrowserRegistrarWin10();
                default:
                    throw new NotSupportedException("The Operating System is not supported.");
            }
        }

        internal abstract void RegisterBrowser();

        internal abstract void UnregisterBrowser();

        internal abstract void SetAsDefault();

        internal abstract bool IsAppSetAsDefault();

        internal abstract Browser GetDefaultBrowser();

        internal abstract Browser[] GetRegisteredBrowsers();

        protected Browser GetBrowserInfo(string appId) {

            if (string.IsNullOrWhiteSpace(appId)) {
                return null;
            }

            Browser browser = new Browser();
            browser.AppId = appId;

            const string exeSuffix = ".exe";
            string path = appId + @"\shell\open\command";
            FileInfo browserPath;
            using (RegistryKey pathKey = Registry.ClassesRoot.OpenSubKey(path)) {
                if (pathKey == null) {
                    return null;
                }

                // Trim parameters.
                try {
                    path = pathKey.GetValue(null).ToString().ToLower().Replace("\"", "");
                    if (!path.EndsWith(exeSuffix)) {
                        path = path.Substring(0, path.LastIndexOf(exeSuffix, StringComparison.Ordinal) + exeSuffix.Length);
                        browserPath = new FileInfo(path);
                        browser.ExePath = browserPath.FullName;
                        browser.Icon = Icon.ExtractAssociatedIcon(browser.ExePath);
                    }
                } catch {
                    // Assume the registry value is set incorrectly, or some funky browser is used which currently is unknown.
                }
            }

            if (string.IsNullOrWhiteSpace(appId)) {
                browser.BrowserType = BrowserType.InternetExplorer;
                browser.Name = "Internet Explorer";
            } else if (appId.Contains("IE.HTTP")) {
                browser.BrowserType = BrowserType.InternetExplorer;
                browser.Name = "Internet Explorer";
            } else if (appId.Contains("Firefox")) {
                browser.BrowserType = BrowserType.Firefox;
                browser.Name = "Firefox";
            } else if (appId.Contains("Chrome")) {
                browser.BrowserType = BrowserType.Chrome;
                browser.Name = "Chrome";
            } else if (appId.Contains("Opera")) {
                browser.BrowserType = BrowserType.Opera;
                browser.Name = "Opera";
            } else if (appId.Contains("Safari")) {
                browser.BrowserType = BrowserType.Safari;
                browser.Name = "Safari";
            } else if (appId.Contains("AppXq0fevzme2pys62n3e0fbqa7peapykr8v")) {
                browser.BrowserType = BrowserType.Edge;
                browser.Name = "Edge";
            } else {
                browser.BrowserType = BrowserType.Unknown;
                browser.Name = "AppId: " + appId;
            }

            return browser;
        }
    }

    enum OSVersion {
        Win7,
        Win8,
        Win10,
        Unknown
    }

}
