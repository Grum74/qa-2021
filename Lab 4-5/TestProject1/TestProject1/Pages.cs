
namespace TestProject1
{
    public static class Pages
    {
        public static OwnersListPage OwnerList => new OwnersListPage();

        public static OwnerCreatePage OwnerCreate => new OwnerCreatePage();

        public static OwnerDetailsPage OwnerDetails => new OwnerDetailsPage();

        public static NavBar NavBar => new NavBar();

        public static PetCreatePage PetCreate => new PetCreatePage(OwnerDetails);
    }
}
