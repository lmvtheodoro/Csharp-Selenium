using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace SeleniumLab.WebDriversConfigs
{
    internal class WebDriverFactory
    {
        internal bool remoteRun;
        internal string browserChoice;
        internal IWebDriver driver;

        internal WebDriverFactory()
        {
            remoteRun = Environment.GetEnvironmentVariable("Run") == "true";
            browserChoice = Environment.GetEnvironmentVariable("Browser") ?? "Chrome";

            Console.WriteLine($"Remote Run: {remoteRun}");
            Console.WriteLine($"Browser Choice: {browserChoice}");

            var chromeOptions = new ChromeOptions();
            var edgeOptions = new EdgeOptions();
            var fireFoxOptions = new FirefoxOptions();

            if (remoteRun)
            {
                chromeOptions.AddArgument("--headless=new");
                chromeOptions.AddArgument("--window-position=-2400,-2400");
                edgeOptions.AddArgument("--headless");
                edgeOptions.AddArgument("--window-position=-2400,-2400");
                fireFoxOptions.AddArgument("--headless");
            }

            switch (browserChoice)
            {
                case "Chrome":
                    chromeOptions.AddArgument("--disable-gpu");
                    chromeOptions.AddArgument("--start-maximized");
                    chromeOptions.AddArgument("--incognito");
                    chromeOptions.AddArguments("--disable-dev-shm-usage");
                    chromeOptions.AddArgument("--disable-extensions");
                    chromeOptions.AddArgument("--disable-infobars");
                    chromeOptions.AddArgument("AcceptInsecureCerts=true");
                    chromeOptions.AddArgument("--ignore-certificate-errors");
                    driver = new ChromeDriver(chromeOptions);
                    break;
                case "Edge":
                    edgeOptions.AddArgument("--disable-gpu");
                    edgeOptions.AddArgument("--start-maximized");
                    edgeOptions.AddArgument("--incognito");
                    edgeOptions.AddArguments("--disable-dev-shm-usage");
                    edgeOptions.AddArgument("--disable-extensions");
                    edgeOptions.AddArgument("--disable-infobars");
                    edgeOptions.AddArgument("AcceptInsecureCerts=true");
                    edgeOptions.AddArgument("--ignore-certificate-errors");
                    driver = new EdgeDriver(edgeOptions);
                    break;
                case "Firefox":
                    fireFoxOptions.AddArgument("--disable-gpu");
                    fireFoxOptions.AddArgument("--start-maximized");
                    fireFoxOptions.AddArgument("--incognito");
                    fireFoxOptions.AddArguments("--disable-dev-shm-usage");
                    fireFoxOptions.AddArgument("--disable-extensions");
                    fireFoxOptions.AddArgument("--disable-infobars");
                    fireFoxOptions.AddArgument("AcceptInsecureCerts=true");
                    fireFoxOptions.AddArgument("--ignore-certificate-errors");
                    driver = new FirefoxDriver(fireFoxOptions);
                    break;
                default:
                    throw new ArgumentException("Browser not defined: " + browserChoice);
            }
        }
        internal void Quit()
        {
            driver.Quit();
        }
    }
}