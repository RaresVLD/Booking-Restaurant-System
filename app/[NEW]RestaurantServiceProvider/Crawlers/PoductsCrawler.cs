using System;
using System.Collections.Generic;
using HtmlAgilityPack;
using RestaurantServiceProvider.Entities;
using System.Text.RegularExpressions;
using RestaurantServiceProvider.ServiceRepository;

namespace RestaurantServiceProvider.Crawlers
{
    public class ProductsCrawler
    {
        private Dictionary<string, string> URLs;
        private List<RestaurantCrawlerDTO> restaurants;


        public ProductsCrawler()
        {

            URLs = new Dictionary<string, string>
           {
                {"https://www.takeaway.com/ro-en/pancks", "Panck's" },
                {"https://www.takeaway.com/ro-en/la-placinte-iasi","La Placinte" },
                {"https://www.takeaway.com/ro-en/oliv","Oliv" },
                {"https://www.takeaway.com/ro-en/fenice","Fenice" },
                {"https://www.takeaway.com/ro-en/mado-palas","Mado Palas" },
                {"https://www.takeaway.com/ro-en/the-trumpets","The Trumpets" },
                {"https://www.takeaway.com/ro-en/chef-galerie","Chef Galerie" },
                {"https://www.takeaway.com/ro-en/legend","Legend Pub" },
                {"https://www.takeaway.com/ro-en/c-house-lounge","C House Lounge" },
                {"https://www.takeaway.com/ro-en/treaz-nu", "Treaz & Nu" },
                {"https://glovoapp.com/ro_RO/ias/store/carbon-iasi/", "Carbon" }
           };

            restaurants = new List<RestaurantCrawlerDTO>();
        }

        private void CrawlProductsInformation()
        {
            foreach (var link in URLs)
            {
                var web = new HtmlWeb();
                var doc = web.Load(link.Key);

                var products = new List<ProductCrawlerDTO>();


                if (link.Key.Contains(".takeaway."))
                {

                    foreach (HtmlNode division in doc.DocumentNode.SelectNodes("//div[contains(@class, 'meal__description-texts js-meal-description-text')]"))
                    {

                        var HtmlDom = division.InnerHtml;
                        HtmlDocument html = new HtmlDocument();

                        html.LoadHtml(HtmlDom);

                        string name = "";
                        string description = "";
                        string price = "0";
                        HtmlNode nameNode = html.DocumentNode.SelectSingleNode("//span[contains(@class, 'meal-name')]");
                        HtmlNode descriptionNode = html.DocumentNode.SelectSingleNode("//div[contains(@class, 'meal__description-additional-info')]");
                        HtmlNode priceNode = html.DocumentNode.SelectSingleNode("//div[contains(@class, 'meal__price')]");

                        if (nameNode != null)
                        {
                            name = nameNode.InnerText.Trim();
                        }

                        if (descriptionNode != null)
                        {
                            description = descriptionNode.InnerText.Trim();
                        }

                        if (priceNode != null)
                        {
                            price = priceNode.InnerText.Trim().Split(' ')[0];
                        }
                        double newPrice = Convert.ToDouble(price) / 100;
                        products.Add(new ProductCrawlerDTO(name, description, newPrice));

                    }
                }
                else
                {
                    foreach (HtmlNode division in doc.DocumentNode.SelectNodes("//div[contains(@class, 'card-content')]"))
                    {
                        var HtmlDom = division.InnerHtml;
                        HtmlDocument html = new HtmlDocument();

                        html.LoadHtml(HtmlDom);

                        string name = "";
                        string description = "";
                        string price = "0";
                        HtmlNode nameNode = html.DocumentNode.SelectSingleNode("//h4[contains(@class, 'title')]");
                        HtmlNode descriptionNode = html.DocumentNode.SelectSingleNode("//div[contains(@class, 'description')]");
                        HtmlNode priceNode = html.DocumentNode.SelectSingleNode("//div[contains(@class, 'price')]");

                        if (nameNode != null)
                        {
                            name = nameNode.InnerText.Trim();
                        }

                        if (descriptionNode != null)
                        {
                            description = descriptionNode.InnerText.Trim();
                        }

                        if (priceNode != null)
                        {
                            price = priceNode.InnerText.Trim().Split(' ')[0];
                        }

                        double newPrice = Convert.ToDouble(price) / 100;
                        products.Add(new ProductCrawlerDTO(name, description, newPrice));
                    }

                }
                restaurants.Add(new RestaurantCrawlerDTO(link.Value, products));
            }

        }

        public List<Product> GetProductsForRestaurants(RestaurantServiceProviderContext context)
        {
            CrawlProductsInformation();

            var products = new List<Product>();
            var restaurantService = new RestaurantRepository(context);
            Guid id;

            foreach (var restaurant in restaurants)
            {
                id = restaurantService.GetRestaurantIdGivenRestaurantName(restaurant.Name);
                foreach (var product in restaurant.Products)
                {
                    products.Add(Product.Create(id, product.Name, product.Description, product.Price));
                }
            }
            return products;
        }
    }

}