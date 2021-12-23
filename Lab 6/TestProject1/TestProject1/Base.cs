using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using Allure.Commons;

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
            driver = new ChromeDriver("driver");
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
    }
}