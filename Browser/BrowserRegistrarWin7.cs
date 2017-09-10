/********************************************************************++
Copyright (c) Shameel Ahmed.  All rights reserved.
--********************************************************************/

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserSelector {

    class BrowserRegistrarWin7 : BrowserRegistrar {

        internal override void RegisterBrowser() {
            //Unregister AppId.
            UnregisterBrowser();

            // Register application.
            var appReg = RootKey.CreateSubKey(string.Format("SOFTWARE\\Clients\\StartMenuInternet\\{0}", AppId));
            appReg.SetValue("", AppName);
            appReg.CreateSubKey("DefaultIcon").SetValue("", AppIcon);
            appReg.CreateSubKey("shell\\open\\command").SetValue("", AppOpenUrlCommand);

            // Install info.
            var appInstallInfo = appReg.CreateSubKey("InstallInfo");
            appInstallInfo.SetValue("IconsVisible", 1);
            appInstallInfo.SetValue("ShowIconsCommand", AppPath); // TOOD: Do I need to support this?
            appInstallInfo.SetValue("HideIconsCommand", AppPath); // TOOD: Do I need to support this?
            appInstallInfo.SetValue("ReinstallCommand", AppReinstallCommand);

            // Register capabilities.
            var capabilityReg = appReg.CreateSubKey("Capabilities");
            capabilityReg.SetValue("ApplicationName", AppName);
            capabilityReg.SetValue("ApplicationIcon", AppIcon);
            capabilityReg.SetValue("ApplicationDescription", AppDescription);

            // Set up protocols we want to handle.
            var urlAssoc = capabilityReg.CreateSubKey("URLAssociations");
            urlAssoc.SetValue("http", AppId);
            urlAssoc.SetValue("https", AppId);
            //urlAssoc.SetValue("ftp", AppID);
        }

        internal override void UnregisterBrowser() {
            RootKey.DeleteSubKeyTree(string.Format("SOFTWARE\\Clients\\StartMenuInternet\\{0}", AppId), false);
        }

        internal override bool IsAppSetAsDefault() {
            //Browser browser = GetDefaultBrowser();
            //return (browser != null && browser.AppId.Equals(AppId, StringComparison.OrdinalIgnoreCase));
            return false;
        }

        internal override Browser GetDefaultBrowser() {
            //string appId = string.Empty;
            //Browser browser = new Browser();

            //using (RegistryKey userChoiceKey = Registry.CurrentUser.OpenSubKey(userChoice)) {
            //    if (userChoiceKey != null) {
            //        object appIdValue = userChoiceKey.GetValue("Progid");
            //        if (appIdValue != null) {
            //            appId = appIdValue.ToString();

            //        }
            //    }
            //    browser.AppId = appId;
            //    return browser;
            //}
            return new Browser();
        }

        internal override void SetAsDefault() {
            //var psi = new ProcessStartInfo() {
            //    FileName = "ms-settings:defaultapps"
            //};

            //var process = new Process();
            //process.StartInfo = psi;
            //process.Start();
        }

        internal override Browser[] GetRegisteredBrowsers() {
            List<Browser> browsers = new List<Browser>();
            //TODO
            return browsers.ToArray();
        }
    }

}
