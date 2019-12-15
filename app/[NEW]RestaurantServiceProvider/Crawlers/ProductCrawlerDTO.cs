using System;
namespace RestaurantServiceProvider.Crawlers
{
    public class ProductCrawlerDTO
    {
        public string Name { get; set;}
        public string Description { get; set;}
        public double Price { get; set;}
        public ProductCrawlerDTO(string name,string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
