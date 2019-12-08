using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider.Utils
{
    public static class UserSeed
    {
        public static User[] CreateUsers()
        {
            return new User[2]
            {
                User.Create("Tudor", "Manoleasa", "tudormanoleasa@gmail.com", "parolatudormanoleasa"),
                User.Create("Roxana", "Apopei", "roxana.apopei@yahoo.com", "parolaroxanaapopei")
            };
        }
    }
}
