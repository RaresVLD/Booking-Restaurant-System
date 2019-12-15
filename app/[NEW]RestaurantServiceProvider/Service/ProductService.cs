using System;
using System.Collections.Generic;
using RestaurantServiceProvider.Entities;
using RestaurantServiceProvider.ServiceRepository;

namespace RestaurantServiceProvider.Service
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public List<Product> GetAllProductsGivenBookingDateTime(DateTime dateTime)
        {
            return _productRepository.GetAllProductsGivenBookingDateTime(dateTime);
        }

        public List<Product> GetAllProductsGivenPriceBelow(int price)
        {
            return _productRepository.GetAllProductsGivenPriceBelow(price);
        }

        public void InsertProductsFromCrawler()
        {
            _productRepository.InsertProductsFromCrawler();
        }
    }
}
