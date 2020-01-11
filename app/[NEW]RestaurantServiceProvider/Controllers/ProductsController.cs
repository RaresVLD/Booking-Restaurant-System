using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RestaurantServiceProvider.Entities;
using RestaurantServiceProvider.Service;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantServiceProvider.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class ProductsController : Controller
    {

        public IProductService _productService;


        public ProductsController(IProductService productService)
        {
            _productService = productService;
            //_productService.InsertProductsFromCrawler();
        }


        [HttpGet]
        public ActionResult Get()
        {
            List<Product> products = _productService.GetAllProducts();
            return Ok(products);
        }


        [HttpGet("booking/datetime/{datetime}")]
        public ActionResult GetAllProductsGivenBookingDateTime(DateTime dateTime)
        {
            List<Product> products = _productService.GetAllProductsGivenBookingDateTime(dateTime);
            return Ok(products);
        }


        [HttpGet("price/{price}")]
        public ActionResult GetAllProductsGivenPriceBelow(int price)
        {
            List<Product> products = _productService.GetAllProductsGivenPriceBelow(price);
            return Ok(products);
        }

    }
}
