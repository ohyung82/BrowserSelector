/********************************************************************++
Copyright (c) Shameel Ahmed.  All rights reserved.
--********************************************************************/

using System;
using System.Reflection;
using Microsoft.Win32;
using System.Security.Permissions;
using System.Diagnostics;
using System.IO;
using System.Drawing;

namespace BrowserSelector {

    internal class Browser {
        internal string Name { get; set; }
        internal string AppId { get; set; }
        internal string ExePath { get; set; }
        internal Icon Icon { get; set; }
        internal BrowserType BrowserType { get; set; }
    }

    internal enum BrowserType {
        InternetExplorer,
        Edge,
        Firefox,
        Chrome,
        Opera,
        Safari,
        Unknown
    }

}