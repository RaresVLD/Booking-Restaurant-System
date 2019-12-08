using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider.Utils
{
    public static class ProductSeed
    {
        public static Product[] CreateProducts(Restaurant[] restaurants)
        {
            return new Product[4]
            {
                Product.Create(restaurants[0].Id, "AripioareMamma", "Super gustoase aripioarele de la mama", 20.5),
                Product.Create(restaurants[0].Id, "PizzaMamma", "Super buna piza de la mama", 30.5),
                Product.Create(restaurants[1].Id, "BorsSergio", "Cel mai bun bors din istoria tatarasi", 10.5),
                Product.Create(restaurants[1].Id, "MamaligaSergio", "Mamaliga goala facuta din malai si apa", 8.5)
            };
        }
    }
}
