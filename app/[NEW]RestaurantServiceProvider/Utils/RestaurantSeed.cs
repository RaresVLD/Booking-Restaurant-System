using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider.Utils
{
    public static class RestaurantSeed
    {
        public static Restaurant[] CreateRestaurants()
        {
            return new Restaurant[2]
            {
                Restaurant.Create("Mamma mia", "Centru", "E super central si chirica e patron"),
                Restaurant.Create("Serginio", "Tatarasi", "E super in tatarasi si patron sunt eu")
            };
        }
    }
}
