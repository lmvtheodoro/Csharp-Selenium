using OpenQA.Selenium;
using SeleniumLab.FrontendHelper;

namespace SeleniumLab.PageObjects
{
    internal class GooglePage
    {
        internal readonly IWebDriver driver;
        internal GooglePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal string Url => "https://www.google.com/";
        internal IWebElement GoogleLogo => driver.FindElement(By.XPath("//img[@alt='Google']"));
        internal IWebElement SearchBox => driver.FindElement(By.Name("q"));

        #region Actions
        internal class Actions
        {
            private readonly GooglePage googlePage;

            public Actions(GooglePage googlePage)
            {
                this.googlePage = googlePage;
            }

            public void GoToGoogleUrl(IWebDriver driver)
            {
                googlePage.driver.Navigate().GoToUrl(googlePage.Url);
                AssertionExtensions.ShouldBeAtUrl(driver, googlePage.Url, "Google URL is not correct");
                AssertionExtensions.ShouldBeVisible(googlePage.GoogleLogo, "Google logo is not visible.");
            }
            public void SearchForTerm(string term)
            {
                AssertionExtensions.ShouldBeVisible(googlePage.SearchBox, "Search box should be visible.");
                AssertionExtensions.ShouldBeEnabled(googlePage.SearchBox, "Search box should be enabled.");

                googlePage.SearchBox.SendKeys(term + Keys.Enter);
            }
        }
        #endregion
    }
}