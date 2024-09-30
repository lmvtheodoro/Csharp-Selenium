using OpenQA.Selenium;
using SeleniumLab.PageObjects;
using NUnit.Framework;
using SeleniumLab.FrontendHelper;
using SeleniumLab.WebDriversConfigs;

namespace SeleniumLab.Automation
{
    internal class TestScenario
    {
        internal required IWebDriver driver;
        internal required WebDriverFactory driverFactory;
        internal required GooglePage googlePage;
        internal required YouTubePage youtubePage;
        internal required GooglePage.Actions actions;

        #region SetUp and TearDown
        [SetUp]
        public void Setup() {
            driverFactory = new WebDriverFactory();
            driver = driverFactory.driver;
            googlePage = new GooglePage(driver);
            youtubePage = new YouTubePage(driver);
            actions = new GooglePage.Actions(googlePage);
        }     
        [TearDown]
        public void TearDown(){
            driverFactory.Quit();
        }
        #endregion

        [Test]
        public void Should_Open_Google_And_Search_For_Selenium()
        {
            actions.GoToGoogleUrl(driver);
            actions.SearchForTerm("Selenium");
            AssertionExtensions.ShouldContainRoute(driver, "/search?q=Selenium", "Google Route is not correct");
        }

        [Test]
        public void Should_Open_YouTube_And_Search_For_Selenium()
        {
            youtubePage.Open();
            Assert.That(driver.Url, Is.EqualTo(youtubePage.Url), "YouTube URL is not correct");
            Assert.That(youtubePage.YouTubeLogo.Displayed, "YouTube logo should be visible.");

            Assert.That(youtubePage.SearchBox.Enabled, "YouTube search box should be enabled.");
            Assert.That(youtubePage.SearchBox.Displayed, "YouTube search box should be visible.");
            youtubePage.SearchBox.Click();
            youtubePage.SearchBox.SendKeys("Selenium" + Keys.Enter);
            Assert.That(driver.Url.ToString(), Does.Contain("/results?search_query=Selenium"), "YouTube Route is not correct");
        }
    }
}