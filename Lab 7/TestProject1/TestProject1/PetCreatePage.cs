using NUnit.Allure.Steps;
using OpenQA.Selenium;

namespace TestProject1
{
    public class PetCreatePage
    {
        private IWebDriver driver;

        private OwnerDetailsPage ownerDetailsPage;

        public PetCreatePage(IWebDriver driver, OwnerDetailsPage ownerDetailsPage)
        {
            this.driver = driver;
            this.ownerDetailsPage = ownerDetailsPage;
        }

        private IWebElement GoBackButton() => driver.FindElement(By.CssSelector(".goBack"));

        private IWebElement SavePetButton() => driver.FindElement(By.CssSelector(".savePet"));

        private IWebElement NameField() => driver.FindElement(By.Id("name"));

        private IWebElement BirthDateField() => driver.FindElement(By.Name("birthDate"));

        private IWebElement TypeSelect() => driver.FindElement(By.Id("type"));


        public PetCreatePage TypeName(string name)
        {
            Helpers.ClearAndType(NameField(), name);
            return this;
        }

        public PetCreatePage TypeBitrhDate(string bitrhDate)
        {
            Helpers.ClearAndType(BirthDateField(), bitrhDate);
            return this;
        }

        public PetCreatePage SelectType(string option)
        {
            TypeSelect().Click();
            TypeSelect().FindElement(By.XPath("//option[. = '" + option + "']")).Click();
            return this;
        }

        public OwnerDetailsPage GoBack()
        {
            GoBackButton().Click();
            return ownerDetailsPage;
        }

        public OwnerDetailsPage SavePet()
        {
            SavePetButton().Click();
            return ownerDetailsPage;
        }
    }
}
