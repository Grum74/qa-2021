using OpenQA.Selenium;

namespace TestProject1
{
    public class OwnerCreatePage : Base
    {
        private By firstNameLocator = By.Id("firstName");
        private By lastNameLocator = By.Id("lastName");
        private By addressLocator = By.Id("address");
        private By cityLocator = By.Id("city");
        private By telephoneLocator = By.Id("telephone");
        private By addOwnerLocator = By.CssSelector("addOwner");

        public OwnerCreatePage TypeFirstname(string firstName)
        {
            driver.FindElement(firstNameLocator).SendKeys(firstName);
            return this;
        }

        public OwnerCreatePage TypeLastname(string lastName)
        {
            driver.FindElement(lastNameLocator).SendKeys(lastName);
            return this;
        }

        public OwnerCreatePage TypeAddress(string address)
        {
            driver.FindElement(addressLocator).SendKeys(address);
            return this;
        }

        public OwnerCreatePage TypeCity(string city)
        {
            driver.FindElement(cityLocator).SendKeys(city);
            return this;
        }

        public OwnerCreatePage TypeTelephone(string telephone)
        {
            driver.FindElement(telephoneLocator).SendKeys(telephone);
            return this;
        }

        public OwnersPage AddOwner()
        {
            driver.FindElement(addOwnerLocator).Submit();
            return new OwnersPage();
        }
    }
}
