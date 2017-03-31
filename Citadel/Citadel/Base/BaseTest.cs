// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseTest.cs" company="">
//   
// </copyright>
// <summary>
//   The base test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Citadel
{
    #region

    using Citadel.BrowerManagement;

    using NUnit.Framework;

    using OpenQA.Selenium;

    #endregion

    /// <summary>
    /// The base test.
    /// </summary>
    public class BaseTest
    {
        /// <summary>
        ///     The browser cleanup.
        /// </summary>
        private readonly IBrowserCleanup browserCleanup = new BrowserCleanup();

        /// <summary>
        /// The browser setup.
        /// </summary>
        private readonly IBrowserSetup browserSetup = new BrowserSetup();

        /// <summary>
        /// Gets or sets the browser.
        /// </summary>
        public IWebDriver Browser { get; set; }

        /// <summary>
        /// Gets or sets the test context.
        /// </summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// The cleanup.
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            this.Browser = this.browserCleanup.Quit(this.Browser);
        }

        /// <summary>
        /// The setup.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.Browser = this.browserSetup.InitiateBrowser(this.Browser);
        }

        /// <summary>
        /// The test class init.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public void TestClassInit(TestContext context)
        {
            this.TestContext = context;
        }
    }
}