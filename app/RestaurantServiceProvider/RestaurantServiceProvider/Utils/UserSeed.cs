namespace RestaurantServiceProvider.Utils
{
    public static class UserSeed
    {
        public static User[] CreateUsers()
        {
            return new User[2]
            {
                User.Create(9, "Roxana", "Apopei", "roxana.apopei@gmail.com", "12345"),
                User.Create(10, "Tudor", "Manoleasa", "tudor.manoleasa@gmail.com", "56780")
            };
        }
    }
}
