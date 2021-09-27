using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObligatoriskRest.Manager;
using ObligatoriskRest.Models;

namespace ObligatoriskRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ItemsManager _manager = new ItemsManager();

        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _manager.GetAll();
        }

        [HttpGet("{id}")]
        public Item Get(int id)
        {
            return _manager.GetById(id);
        }

        [HttpPost]
        public Item Post([FromBody] Item value)
        {
            return _manager.Add(value);
        }

        [HttpPut("{id}")]
        public Item Put(int id, [FromBody] Item value)
        {
            return _manager.Update(id, value);
        }

        [HttpDelete("{id}")]
        public Item Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
