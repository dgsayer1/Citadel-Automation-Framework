using Citadel.Constants;
using OpenQA.Selenium;

namespace Citadel.BrowerManagement
{
    internal interface IBrowserSetup
    {
        IWebDriver InitiateBrowser(IWebDriver browser, BrowserTypeEnums.BrowserTypes browserType = BrowserTypeEnums.BrowserTypes.ChromeBrowser);
    }
}