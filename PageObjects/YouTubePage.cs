using OpenQA.Selenium;

namespace SeleniumLab.PageObjects
{
    internal class YouTubePage
    {
        internal readonly IWebDriver driver;
        internal string Url = "https://www.youtube.com/";
        internal YouTubePage(IWebDriver driver){
            this.driver = driver;
        }
        internal void Open()
        {
            driver.Navigate().GoToUrl(Url);
        }

        internal IWebElement YouTubeLogo => driver.FindElement(By.Id("logo"));
        internal IWebElement SearchBox => driver.FindElement(By.CssSelector("input#search"));
    }
}