using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Citadel.BrowerManagement
{
    internal class BrowserCleanup : IBrowserCleanup
    {
        public IWebDriver Quit(IWebDriver browser)
        {
            browser.Quit();
            browser = this.Dispose(browser);
            if (browser != null)
            {
                this.Close(browser);
            }
            return browser;
        }

        private void Close(IWebDriver browser)
        {
            browser.Close();
        }

        private IWebDriver Dispose(IWebDriver browser)
        {
            browser?.Dispose();
            browser = null;
            return browser;
        }
    }
}
