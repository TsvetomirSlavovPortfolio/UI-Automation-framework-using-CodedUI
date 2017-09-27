using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VievuWeb.BowserFactory
{
    class Browser
    {
        private BrowserWindow browser;
        public BrowserWindow GetBrowser(String BrowserName, string URL)
        {
            switch (BrowserName)
            {
                case "Ie":
                    BrowserWindow.CurrentBrowser = "ie";
                    browser = BrowserWindow.Launch(URL);
                    MaximizeBrowser(browser);
                    break;
                case "Chrome":
                    BrowserWindow.CurrentBrowser = "Chrome";
                    browser = BrowserWindow.Launch(URL);
                    MaximizeBrowser(browser);
                    break;
                default:
                    browser = null;
                    break;

            }
            return browser;
        }

        private void MaximizeBrowser(BrowserWindow browser)
        {
            browser.Maximized = true;


        }

    }
}



