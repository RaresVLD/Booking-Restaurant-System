using Microsoft.AspNetCore.Mvc;
using RestaurantServiceProvider.Entities;
using RestaurantServiceProvider.ServiceRepository;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantServiceProvider.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommandsController : ControllerBase
    {

        public ICommandServiceRepository _command;

        public CommandsController(ICommandServiceRepository command)
        {
            _command = command;
        }

        [HttpGet]
        public ActionResult<Command> Get()
        {
            List<Command> commands = _command.GetAllCommands().ToList();
            return Ok(commands);
        }
        [HttpGet("get/{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            Command command = _command.GetCommandById(id);
            return Ok(command);
        }
        [HttpGet("get/{id}/products")]
        public ActionResult<Product> GetProductsById(int id)
        {
            List<Product> products = _command.GetProductsForCommandId(id);
            return Ok(products);
        }

    }
}
