using OpenQA.Selenium;

namespace TestProject1
{
    public class OwnersListPage : Base
    {
        private IWebElement AddOwnerButton() => driver.FindElement(By.CssSelector("addOwner"));

        private IWebElement OwnerPageLink(string linkText) => driver.FindElement(By.LinkText(linkText));

        public OwnerCreatePage AddOwner()
        {
            AddOwnerButton().Submit();
            return new OwnerCreatePage();
        }

        public OwnerDetailsPage OpenOwnerPage(string linkText)
        {
            OwnerPageLink(linkText).Click();
            return new OwnerDetailsPage();
        }
    }
}
