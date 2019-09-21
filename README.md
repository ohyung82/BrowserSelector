# BrowserSelector
Browser Selector is a WinForms app written in C# that allows you to associate different urls with different browsers.

## Introduction

This article introduces you to BrowserSelector, an open source app that acts like a bootstrap to associate urls to different browsers installed on your machine,

As developers and technology buffs, we’ve always felt the need to automatically open different urls with our favorite browsers. The problem is we had to open the right browser to navigate to that url. When clicking links in email clients, it opens the link in the default browser when we intend to open it with a particular browser because that is what it works with best.

## How it works?

Browser Selector is a WinForms app written in C# that registers itself as a browser. Here is what happens:

1. User clicks url in an email client or opens the url in the Run dialog (www.google.com)
2. Windows intercepts the url and opens the url in the default browser (Browser Selector) 

Browser Selector runs the url through all the rules and opens the link in the browser associated with the first matching rule. If no matching rule exists, the url is opened in the fallback browser.
How Browser Selector Works

## Browser Selector Main Window
## Supported Platforms

1. Windows  8/8.1
2. Windows 10

## Steps to install

No installation is required. Just XCopy the binary files to any folder and run the .exe. In the UI, click Tools –> Register Browser. Browser Selector registers itself as a browser and opens the Default Apps settings page where you can set Browser Selector as the default browser.
Register Browser Menu
Windows Default Apps

That’s it, you’re done.

## Define Rules

1. Select a Match type, enter the Url in the text box and select a Browser and click the ‘+ ‘ button to add the rule.
2. Select a rule in the list and click the ‘X’ button to delete the rule.
3. Use the Up and Down buttons to move the rule up or down respectively. Rules are evaluated in the displayed order.
4. Select a Fallback Browser to be used when the url does not match any rule.
5. Turning on the ‘Use this Browser for all Urls’ check box bypasses all rules and uses the selected Browser to all urls until it is turned off.
6. Changes to settings and rules are saved only when the app is closed. Make sure you close the app before trying out the changes.

## Put it to test

Open Start –> Run, enter the url and click OK.
Windows Run

Try out with different urls that match your rules.

Visit http://www.thedeveloperspace.com/post/browser-selector for more information.
