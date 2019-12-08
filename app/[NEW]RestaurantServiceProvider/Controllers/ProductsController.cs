using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RestaurantServiceProvider.Entities;
using RestaurantServiceProvider.ServiceRepository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantServiceProvider.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class ProductsController : Controller
    {

        public IProductServiceRepository _productRepository;


        public ProductsController(IProductServiceRepository productRepository)
        {
            _productRepository = productRepository;
        }


        [HttpGet]
        public ActionResult Get()
        {
            List<Product> products = _productRepository.GetAllProducts();
            return Ok(products);
        }


        [HttpGet("booking/datetime/{datetime}")]
        public ActionResult GetAllProductsGivenBookingDateTime(DateTime dateTime)
        {
            List<Product> products = _productRepository.GetAllProductsGivenBookingDateTime(dateTime);
            return Ok(products);
        }


        [HttpGet("price/{price}")]
        public ActionResult GetAllProductsGivenPriceBelow(int price)
        {
            List<Product> products = _productRepository.GetAllProductsGivenPriceBelow(price);
            return Ok(products);
        }

    }
}
