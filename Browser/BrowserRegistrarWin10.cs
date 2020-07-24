/********************************************************************++
Copyright (c) Shameel Ahmed.  All rights reserved.
--********************************************************************/

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserSelector {

    class BrowserRegistrarWin10 : BrowserRegistrar {

        internal override void RegisterBrowser() {
            //Unregister AppId.
            UnregisterBrowser();

            RegistryKey appReg = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);

            appReg = appReg.CreateSubKey("AdroitTechnologies", RegistryKeyPermissionCheck.ReadWriteSubTree);
            appReg = appReg.CreateSubKey("BrowserSelector", RegistryKeyPermissionCheck.ReadWriteSubTree);

            // Register capabilities.
            var capabilityReg = appReg.CreateSubKey("Capabilities");
            capabilityReg.SetValue("ApplicationName", AppName);
            capabilityReg.SetValue("ApplicationIcon", AppIcon);
            capabilityReg.SetValue("ApplicationDescription", AppDescription);

            // Set up protocols we want to handle.
            var urlAssoc = capabilityReg.CreateSubKey("URLAssociations");
            urlAssoc.SetValue("http", AppId);
            urlAssoc.SetValue("https", AppId);

            var regApps = RootKey.OpenSubKey(@"SOFTWARE\RegisteredApplications", true);
            regApps.SetValue(AppId, @"SOFTWARE\AdroitTechnologies\BrowserSelector\Capabilities");

            string keyName = @"SOFTWARE\Classes\" + AppId;
            var classesReg = Registry.CurrentUser.CreateSubKey(keyName);
            classesReg.SetValue("", AppName);
            classesReg.CreateSubKey("DefaultIcon").SetValue("", AppIcon);
            classesReg.CreateSubKey("shell\\open\\command").SetValue("", AppOpenUrlCommand);

            classesReg = RootKey.CreateSubKey(keyName);
            classesReg.SetValue("", AppName);
            classesReg.CreateSubKey("DefaultIcon").SetValue("", AppIcon);
            classesReg.CreateSubKey("shell\\open\\command").SetValue("", AppOpenUrlCommand);
        }

        internal override void UnregisterBrowser() {
            // Unregister application.
            string regClasses = @"Software\Classes\" + AppId;

            try {
                var regAppsCU = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\RegisteredApplications", true);
                regAppsCU.DeleteValue(AppId);
                Registry.CurrentUser.DeleteSubKeyTree(regClasses);
                Registry.CurrentUser.DeleteSubKeyTree(@"SOFTWARE\AdroitTechnologies\BrowserSelector");
            } catch {

            }

            try {
                var regAppsLM = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\RegisteredApplications", true);
                regAppsLM.DeleteValue(AppId);
                Registry.LocalMachine.DeleteSubKeyTree(regClasses);
                Registry.LocalMachine.DeleteSubKeyTree(@"SOFTWARE\AdroitTechnologies\BrowserSelector");
            } catch {

            }
        }

        internal override bool IsAppSetAsDefault() {
            Browser browser = GetDefaultBrowser();
            return (browser != null && browser.AppId.Equals(AppId, StringComparison.OrdinalIgnoreCase));
        }

        internal override Browser GetDefaultBrowser() {
            string appId = string.Empty;
            Browser browser = new Browser();

            using (RegistryKey userChoiceKey = Registry.CurrentUser.OpenSubKey(userChoice)) {
                if (userChoiceKey != null) {
                    object appIdValue = userChoiceKey.GetValue("Progid");
                    if (appIdValue != null) {
                        appId = appIdValue.ToString();
                    }
                }
                browser.AppId = appId;
                return browser;
            }
        }

        internal override void SetAsDefault() {
            var psi = new ProcessStartInfo() {
                FileName = "ms-settings:defaultapps"
            };

            var process = new Process();
            process.StartInfo = psi;
            process.Start();
        }

        internal override Browser[] GetRegisteredBrowsers() {
            List<Browser> browsers = new List<Browser>();
            AddBrowsers(browsers, true);
            AddBrowsers(browsers, false);
            return browsers.ToArray();
        }

        private void AddBrowsers(List<Browser> browsers, bool currentUser) {
            List<string> valueNames = new List<string>();

            try {
                RegistryKey rootKey = currentUser ? Registry.CurrentUser : Registry.LocalMachine;

                var regApps = rootKey.OpenSubKey(@"SOFTWARE\RegisteredApplications");
                var regValuesCU = regApps.GetValueNames();
                valueNames.AddRange(regValuesCU);

                foreach (string regValue in valueNames.ToArray()) {
                    string capabilitiesPath = Convert.ToString(regApps.GetValue(regValue)); //This has the capabilities key location

                    var capabilitiesKey = rootKey.OpenSubKey(capabilitiesPath);
                    if (capabilitiesKey != null) {
                        var urlAssocKey = capabilitiesKey.OpenSubKey("URLAssociations");
                        if (urlAssocKey != null) {
                            var objAppId = urlAssocKey.GetValue("http");
                            if (objAppId != null) {
                                string appId = Convert.ToString(objAppId);
                                if (appId != null && appId != AppId) { //Exclude BrowserSelector
                                    if (browsers.Count(b => b.AppId.Equals(appId, StringComparison.OrdinalIgnoreCase)) == 0) { //If not already added
                                        Browser browser = GetBrowserInfo(appId);
                                        if (browser != null) {
                                            browsers.Add(browser);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } catch {
                throw;
            }
        }
    }

}
