using NUnit.Allure.Steps;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestProject1
{
    public class NavBar
    {
        private IWebDriver driver;

        public NavBar(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement OwnerTab() => driver.FindElement(By.CssSelector(".ownerTab"));

        private IWebElement AddNewOwnerButton() => driver.FindElement(By.CssSelector(".open li:nth-child(2) > a"));

        private IWebElement OwnerListButton() => driver.FindElement(By.CssSelector(".open li:nth-child(1) > a"));

        [AllureStep("Open owners list page")]
        public OwnersListPage OpenOwnerList()
        {
            OwnerTab().Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".open li:nth-child(1) > a")));
            OwnerListButton().Click();
            return new OwnersListPage(driver);
        }


        public OwnerCreatePage OpenCreateOwnerPage()
        {
            OwnerTab().Click();
            AddNewOwnerButton().Click();
            return new OwnerCreatePage(driver);
        }
    }
}
