using NUnit.Allure.Steps;
using OpenQA.Selenium;

namespace TestProject1
{
    public class OwnerDetailsPage
    {
        private IWebDriver driver;

        public OwnerDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement GoBackButton() => driver.FindElement(By.CssSelector(".goBack"));

        private IWebElement EditOwnerButton() => driver.FindElement(By.CssSelector(".editOwner"));

        private IWebElement AddNewPetButton() => driver.FindElement(By.CssSelector(".addNewPet"));

        [AllureStep("Back to owners list page")]
        public OwnersListPage GoBack()
        {
            GoBackButton().Click();
            return new OwnersListPage(driver);
        }

        [AllureStep("Edit owner")]
        public OwnerCreatePage EditOwner()
        {
            EditOwnerButton().Click();
            return new OwnerCreatePage(driver);
        }

        [AllureStep("Add new pet to owner")]
        public PetCreatePage AddNewPet()
        {
            AddNewPetButton().Click();
            return new PetCreatePage(driver, this);
        }
    }
}
