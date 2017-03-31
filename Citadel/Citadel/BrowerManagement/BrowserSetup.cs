using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;
using static Citadel.Constants.BrowserTypeEnums;

namespace Citadel.BrowerManagement
{
    internal class BrowserSetup : IBrowserSetup
    {
        public IWebDriver InitiateBrowser(IWebDriver browser, BrowserTypes browserType = BrowserTypes.ChromeBrowser)
        {
            var type = browserType;
            switch (type)
            {
                case BrowserTypes.ChromeBrowser:
                    browser = new ChromeDriver();
                    break;
                case BrowserTypes.FirefoxBrowser:
                    browser = new FirefoxDriver();
                    break;
                case BrowserTypes.InternetExplorerBrowser:
                    browser = new InternetExplorerDriver();
                    break;
                case BrowserTypes.EdgeBrowser:
                    browser = new EdgeDriver();
                    break;
                case BrowserTypes.PhantomBrowser:
                    browser = new PhantomJSDriver();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(browserType), browserType, null);
            }
            return browser;
        }
    }
}
