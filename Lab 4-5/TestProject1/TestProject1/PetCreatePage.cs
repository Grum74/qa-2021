using OpenQA.Selenium;

namespace TestProject1
{
    public class PetCreatePage : Base
    {
        private OwnerDetailsPage ownerDetailsPage;

        private IWebElement GoBackButton() => driver.FindElement(By.ClassName("goBack"));

        private IWebElement SavePetButton() => driver.FindElement(By.ClassName("savePet"));

        private IWebElement NameField() => driver.FindElement(By.Id("name"));

        private IWebElement BirthDateField() => driver.FindElement(By.Name("birthDate"));

        private IWebElement TypeSelect() => driver.FindElement(By.Id("type"));

        public PetCreatePage(OwnerDetailsPage ownerDetailsPage)
        {
            this.ownerDetailsPage = ownerDetailsPage;
        }

        public PetCreatePage TypeName(string name)
        {
            NameField().SendKeys(name);
            return this;
        }

        public PetCreatePage TypeBitrhDate(string bitrhDate)
        {
            BirthDateField().SendKeys(bitrhDate);
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
