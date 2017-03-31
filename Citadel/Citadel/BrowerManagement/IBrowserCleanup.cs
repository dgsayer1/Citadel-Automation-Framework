using OpenQA.Selenium;

namespace Citadel.BrowerManagement
{
    internal interface IBrowserCleanup
    {
        IWebDriver Quit(IWebDriver browser);
    }
}