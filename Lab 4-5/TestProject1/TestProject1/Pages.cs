
namespace TestProject1
{
    public static class Pages
    {
        public static OwnersListPage OwnerList => new OwnersListPage(Base.driver);

        public static OwnerCreatePage OwnerCreate => new OwnerCreatePage(Base.driver);

        public static OwnerDetailsPage OwnerDetails => new OwnerDetailsPage(Base.driver);

        public static NavBar NavBar => new NavBar(Base.driver);

        public static PetCreatePage PetCreate => new PetCreatePage(Base.driver, OwnerDetails);
    }
}
