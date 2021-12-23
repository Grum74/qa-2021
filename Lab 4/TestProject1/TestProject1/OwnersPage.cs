using OpenQA.Selenium;

namespace TestProject1
{
    public class OwnersPage : Base
    {
        private By addOwnerLocator = By.CssSelector("addOwner");

        public OwnerCreatePage AddOwner()
        {
            driver.FindElement(addOwnerLocator).Submit();
            return new OwnerCreatePage();
        }
    }
}
