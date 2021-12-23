using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace TestProject1
{
    public class Base
    {
        protected IWebDriver driver;
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
                string path = @"D:\LabsPoli\QA\Lab 4\res";
                string imageName = $"results_{DateTime.Now:yyyy-MM-dd_HH-mm-ss.fffff}.png";
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(path + imageName);
            }

            driver.Quit();
        }
    }
}