using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RestaurantServiceProvider.Entities;
using RestaurantServiceProvider.ServiceRepository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantServiceProvider.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        public IProductServiceRepository _product;

        public ProductsController(IProductServiceRepository product)
        {

            _product = product;
        }

        [HttpGet]
        public ActionResult<Product> Get()
        {
            List<Product> products = _product.GetProducts();
            return Ok(products);
        }

        [HttpGet("get/id/{id}")]
        public ActionResult<Product> GetProductsById(int id)
        {
            List<Product> products = _product.GetProductsById(id);
            return Ok(products);
        }

        [HttpGet("get/menu/id/{id}")]
        public ActionResult<Product> GetProductsByMenuId(int id)
        {
            List<Product> products = _product.GetProductsByMenuId(id);
            return Ok(products);
        }

        [HttpGet("get/name/{name}")]
        public ActionResult<Product> GetProductsByName(string name)
        {
            List<Product> products = _product.GetProductsByName(name);
            return Ok(products);
        }

        [HttpGet("get/price/{price}")]
        public ActionResult<Product> GetProductsByPrice(double price)
        {
            List<Product> products = _product.GetProductsByPrice(price);
            return Ok(products);
        }
    }
}
