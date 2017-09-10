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
using System.Windows.Forms;
using BrowserSelector.Core;
using System.Collections;

namespace BrowserSelector {
    internal class BrowserManager {

        static Browser[] browsers;
        static List<Rule> rules;

        static BrowserManager() {
            LoadBrowsers();
            LoadRules();
        }

        private static void LoadBrowsers() {
            browsers = BrowserRegistrationManager.GetRegisteredBrowsers();

            //Edge quirk
            Browser edge = GetBrowserByName("Edge");
            if (edge != null) {
                edge.ExePath = "microsoft-edge:";
            }
        }

        private static void LoadRules() {
            rules = new List<Rule>();
            if (BrowserSettings.Rules != null) {
                ArrayList ruleList = BrowserSettings.Rules;
                foreach (object objRule in ruleList) {
                    Rule rule = Rule.Parse(Convert.ToString(objRule));
                    if (rule != null) {
                        rules.Add(rule);
                    }
                }
            }

            rules.Sort();
        }

        static internal Browser[] Browsers {
            get {
                return browsers;
            }
        }

        static internal void LaunchUrl(string url) {
            url = GetSanitizedUrl(url);
            Browser browser = null;
            if (BrowserSettings.UseDefaultBrowserForAllLinks) {
                browser = GetBrowserByName(BrowserSettings.DefaultBrowserName);
            } else {
                browser = GetBrowserForUrl(url);
            }

            var psi = new ProcessStartInfo();
            if (browser.ExePath.EndsWith(":")) {
                psi.FileName = string.Format("{0}{1}", browser.ExePath, url);
            } else {
                psi.FileName = browser.ExePath;
                psi.Arguments = url;
            }

            var process = new Process() {
                StartInfo = psi
            };

            process.Start();
        }

        static internal void LaunchUrlWithBrowser(string url, string browserName) {
            url = GetSanitizedUrl(url);
            Browser browser = null;
            browser = GetBrowserByName(browserName);

            var psi = new ProcessStartInfo();
            if (browser.ExePath.EndsWith(":")) {
                psi.FileName = string.Format("{0}{1}", browser.ExePath, url);
            } else {
                psi.FileName = browser.ExePath;
                psi.Arguments = url;
            }

            var process = new Process() {
                StartInfo = psi
            };

            process.Start();
        }

        static Browser GetBrowserForUrl(string url) {
            Browser browser = null;

            url = GetSanitizedUrl(url);

            Rule rule = rules.FirstOrDefault(r => r.IsMatch(url));

            if (rule != null) {
                browser = GetBrowserByName(rule.BrowserName);
            }

            if (browser == null) {
                browser = GetBrowserByName(BrowserSettings.DefaultBrowserName);
            }

            if (browser == null) {
                browser = BrowserManager.GetBrowserByType(BrowserType.InternetExplorer);
            }

            //MessageBox.Show(string.Format("url={0}\nBrowser={1}", url, browser.Name), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return browser;
        }

        internal static string GetSanitizedUrl(string url) {
            //if (url.StartsWith("https://")) {
            //    url = url.Substring(8);
            //} else if (url.StartsWith("http://")) {
            //    url = url.Substring(7);
            //}

            url = url.Trim();
            while (url.EndsWith("/")) {
                url = url.Substring(0, url.Length - 1);
            }

            return url;
        }

        static Browser GetBrowserByType(BrowserType browserType) {
            return browsers.FirstOrDefault(b => b.BrowserType == browserType);
        }

        internal static Browser GetBrowserByName(string browserName) {
            return browsers.FirstOrDefault(b => b.Name.Equals(browserName, StringComparison.OrdinalIgnoreCase));
        }

    }

}