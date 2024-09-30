using NUnit.Framework;
using OpenQA.Selenium;


namespace SeleniumLab.FrontendHelper
{
    internal static class AssertionExtensions
    {
        internal static void ShouldBeEnabled(this IWebElement element, string message)
        {
            Assert.That(element.Enabled, Is.True, message);
        }
        internal static void ShouldBeVisible(this IWebElement element, string message)
        {
            Assert.That(element.Displayed, Is.True, message);
        }
        internal static void ShouldBeAtUrl(this IWebDriver driver, string expectedUrl, string message)
        {
            Assert.That(driver.Url, Is.EqualTo(expectedUrl), message);
        }
        internal static void ShouldContainRoute(this IWebDriver driver, string expectedRoute, string message)
        {
            var currentUrl = new Uri(driver.Url);
            Assert.That(currentUrl.ToString(), Does.Contain(expectedRoute), message);
        }
        internal static void ShouldContainText(this IWebElement element, string expectedText, string message)
        {
            Assert.That(element.Text, Does.Contain(expectedText), message);
        }
        internal static void ShouldHaveAttribute(this IWebElement element, string attribute, string expectedValue, string message)
        {
            Assert.That(element.GetAttribute(attribute), Is.EqualTo(expectedValue), message);
        }  
    }
}