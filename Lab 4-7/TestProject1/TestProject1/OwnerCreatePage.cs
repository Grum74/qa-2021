using NUnit.Allure.Steps;
using OpenQA.Selenium;

namespace TestProject1
{
    public class OwnerCreatePage
    {
        private IWebDriver driver;

        public OwnerCreatePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement FirstNameField() => driver.FindElement(By.Id("firstName"));

        private IWebElement LastNameField() => driver.FindElement(By.Id("lastName"));

        private IWebElement AddressField() => driver.FindElement(By.Id("address"));

        private IWebElement CityField() => driver.FindElement(By.Id("city"));

        private IWebElement TelephoneField() => driver.FindElement(By.Id("telephone"));

        private IWebElement AddOwnerButton() => driver.FindElement(By.CssSelector(".addOwner"));

        private IWebElement UpdateOwnerButton() => driver.FindElement(By.CssSelector(".updateOwner"));

        public OwnerCreatePage TypeFirstname(string firstName)
        {
            Helpers.ClearAndType(FirstNameField(), firstName);
            return this;
        }

        public OwnerCreatePage TypeLastname(string lastName)
        {
            Helpers.ClearAndType(LastNameField(), lastName);
            return this;
        }

        public OwnerCreatePage TypeAddress(string address)
        {
            Helpers.ClearAndType(AddressField(), address);
            return this;
        }

        public OwnerCreatePage TypeCity(string city)
        {
            Helpers.ClearAndType(CityField(), city);
            return this;
        }

        public OwnerCreatePage TypeTelephone(string telephone)
        {
            Helpers.ClearAndType(TelephoneField(), telephone);
            return this;
        }

        public OwnersListPage AddOwner()
        {
            AddOwnerButton().Click();
            return new OwnersListPage(driver);
        }

        public OwnerDetailsPage UpdateOwner(OwnerDetailsPage OwnerDetailsPage)
        {
            UpdateOwnerButton().Click();
            return OwnerDetailsPage;
        }
    }
}
