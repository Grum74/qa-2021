using OpenQA.Selenium;

namespace TestProject1
{
    public class OwnerDetailsPage : Base
    {
        private IWebElement GoBackButton() => driver.FindElement(By.ClassName("goBack"));

        private IWebElement EditOwnerButton() => driver.FindElement(By.ClassName("editOwner"));

        private IWebElement AddNewPetButton() => driver.FindElement(By.ClassName("addNewPet"));

        public OwnersListPage GoBack()
        {
            GoBackButton().Click();
            return new OwnersListPage();
        }

        public OwnerCreatePage EditOwner()
        {
            EditOwnerButton().Click();
            return new OwnerCreatePage();
        }

        public PetCreatePage AddNewPet()
        {
            AddNewPetButton().Click();
            return new PetCreatePage(this);
        }
    }
}
