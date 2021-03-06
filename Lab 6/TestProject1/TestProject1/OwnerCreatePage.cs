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

        [AllureStep("Type owner's firsname")]
        public OwnerCreatePage TypeFirstname(string firstName)
        {
            Helpers.ClearAndType(FirstNameField(), firstName);
            return this;
        }

        [AllureStep("Type owner's lastname")]
        public OwnerCreatePage TypeLastname(string lastName)
        {
            Helpers.ClearAndType(LastNameField(), lastName);
            return this;
        }

        [AllureStep("Type owner's address")]
        public OwnerCreatePage TypeAddress(string address)
        {
            Helpers.ClearAndType(AddressField(), address);
            return this;
        }

        [AllureStep("Type owner's city")]
        public OwnerCreatePage TypeCity(string city)
        {
            Helpers.ClearAndType(CityField(), city);
            return this;
        }

        [AllureStep("Type owner's telephone")]
        public OwnerCreatePage TypeTelephone(string telephone)
        {
            Helpers.ClearAndType(TelephoneField(), telephone);
            return this;
        }

        [AllureStep("Sumbit add new owner")]
        public OwnersListPage AddOwner()
        {
            AddOwnerButton().Submit();
            return new OwnersListPage(driver);
        }

        [AllureStep("Sumbit update owner")]
        public OwnerDetailsPage UpdateOwner(OwnerDetailsPage OwnerDetailsPage)
        {
            UpdateOwnerButton().Submit();
            return OwnerDetailsPage;
        }
    }
}
