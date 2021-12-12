using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using Allure.Commons;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;

namespace TestProject1
{
    public class Base
    {
        public static IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        protected IJavaScriptExecutor js;

        [SetUp]
        public void SetUp()
        {
            ChooseBrowser(BrowserType.Chrome);
            driver.Manage().Window.Size = Helpers.SetSize();
            driver.Url = "http://20.50.171.10:8080/";
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }

        [TearDown]
        protected void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                string imageName = TestContext.CurrentContext.Test.MethodName + "_screenshot_" + DateTime.Now.Ticks + ".png";
                string path = $"D:\\LabsPoli\\TestResults\\{imageName}";

                screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
                AllureLifecycle.Instance.AddAttachment(imageName, "image/png", path);
            }

            driver.Quit();
        }

        protected void ChooseBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.IE:
                    driver = IeDriver();
                    break;
                case BrowserType.Firefox:
                    driver = FirefoxDriver();
                    break;
                case BrowserType.Chrome:
                    driver = ChromeDriver();
                    break;
                default:
                    driver = new ChromeDriver("driver");
                    break;
            }
        }

        protected enum BrowserType
        {
            IE,
            Chrome,
            Firefox
        }

        private IWebDriver IeDriver()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.EnsureCleanSession = true;
            IWebDriver driver = new InternetExplorerDriver("driver", options);
            return driver;
        }

        private IWebDriver FirefoxDriver()
        {
            FirefoxOptions options = new FirefoxOptions();
            IWebDriver driver = new FirefoxDriver("driver", options);
            return driver;
        }

        private IWebDriver ChromeDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            IWebDriver driver = new ChromeDriver("driver", chromeOptions);
            return driver;
        }
    }
}