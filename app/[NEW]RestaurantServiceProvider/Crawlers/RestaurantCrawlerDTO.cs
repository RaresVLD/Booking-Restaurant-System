using System.Collections.Generic;

namespace RestaurantServiceProvider.Crawlers
{
    public class RestaurantCrawlerDTO
    {
        public string Name { get; set;}
        public List<ProductCrawlerDTO> Products { get; set; }

        public RestaurantCrawlerDTO(string name, List<ProductCrawlerDTO> products)
        {
            Name = name;
            Products = products;
        }
    }
}
