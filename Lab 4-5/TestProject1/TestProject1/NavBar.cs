using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestProject1
{
    public class NavBar : Base
    {
        private IWebElement OwnerTab() => driver.FindElement(By.ClassName("ownerTab"));

        private IWebElement AddNewOwnerButton() => driver.FindElement(By.CssSelector(".open li:nth-child(2) > a"));

        private IWebElement OwnerListButton() => driver.FindElement(By.CssSelector(".open li:nth-child(1) > a"));

        public OwnersListPage OpenOwnerList()
        {
            OwnerTab().Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".open li:nth-child(1) > a")));
            OwnerListButton().Click();
            return new OwnersListPage();
        }

        public OwnerCreatePage OpenCreateOwnerPage()
        {
            OwnerTab().Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".open li:nth-child(2) > a")));
            AddNewOwnerButton().Click();
            return new OwnerCreatePage();
        }
    }
}
