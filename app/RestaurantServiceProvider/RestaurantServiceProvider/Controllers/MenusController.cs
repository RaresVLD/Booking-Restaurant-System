using Microsoft.AspNetCore.Mvc;
using RestaurantServiceProvider.Entities;
using RestaurantServiceProvider.ServiceRepository;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantServiceProvider.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class MenusController : ControllerBase
    {
        public IMenuServiceRepository _menu;

        public MenusController(IMenuServiceRepository menu)
        {

            _menu = menu;
        }

        [HttpGet]
        public ActionResult<Menu> Get()
        {
            List<Menu> menus = _menu.getAllMenus().ToList();
            return Ok(menus);
        }
        [HttpGet("get/{id}")]
        public ActionResult<Menu> GetMenuById(int id)
        {
            var menu = _menu.GetMenuById(id);
            return Ok(menu);
        }        

        [HttpGet("get/{id}/products")]
        public ActionResult<Product> GetProductsById(int id)
        {
            var products = _menu.GetProductsByMenuId(id);
            return Ok(products);
        }

    }
}
