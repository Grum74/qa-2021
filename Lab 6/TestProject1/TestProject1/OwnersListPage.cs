using NUnit.Allure.Steps;
using OpenQA.Selenium;

namespace TestProject1
{
    public class OwnersListPage
    {
        private IWebDriver driver;

        public OwnersListPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement AddOwnerButton() => driver.FindElement(By.CssSelector(".addOwner"));

        private IWebElement OwnerPageLink(string linkText) => driver.FindElement(By.LinkText(linkText));

        [AllureStep("Add new owner")]
        public OwnerCreatePage AddOwner()
        {
            AddOwnerButton().Submit();
            return new OwnerCreatePage(driver);
        }

        [AllureStep("Open owners detail page")]
        public OwnerDetailsPage OpenOwnerPage(string linkText)
        {
            OwnerPageLink(linkText).Click();
            return new OwnerDetailsPage(driver);
        }
    }
}
