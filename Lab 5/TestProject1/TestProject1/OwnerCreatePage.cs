using OpenQA.Selenium;

namespace TestProject1
{
    public class OwnerCreatePage : Base
    {
        private IWebElement FirstNameField() => driver.FindElement(By.Id("firstName"));

        private IWebElement LastNameField() => driver.FindElement(By.Id("lastName"));

        private IWebElement AddressField() => driver.FindElement(By.Id("address"));

        private IWebElement CityField() => driver.FindElement(By.Id("city"));

        private IWebElement TelephoneField() => driver.FindElement(By.Id("telephone"));

        private IWebElement AddOwnerButton() => driver.FindElement(By.CssSelector(".addOwner"));

        private IWebElement UpdateOwnerButton() => driver.FindElement(By.CssSelector(".updateOwner"));

        public OwnerCreatePage TypeFirstname(string firstName)
        {
            FirstNameField().SendKeys(firstName);
            return this;
        }

        public OwnerCreatePage TypeLastname(string lastName)
        {
            LastNameField().SendKeys(lastName);
            return this;
        }

        public OwnerCreatePage TypeAddress(string address)
        {
            AddressField().SendKeys(address);
            return this;
        }

        public OwnerCreatePage TypeCity(string city)
        {
            CityField().SendKeys(city);
            return this;
        }

        public OwnerCreatePage TypeTelephone(string telephone)
        {
            TelephoneField().SendKeys(telephone);
            return this;
        }

        public OwnersListPage AddOwner()
        {
            AddOwnerButton().Submit();
            return new OwnersListPage();
        }

        public OwnerDetailsPage UpdateOwner(OwnerDetailsPage OwnerDetailsPage)
        {
            UpdateOwnerButton().Submit();
            return OwnerDetailsPage;
        }
    }
}
