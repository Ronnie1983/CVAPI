using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using CVAPI.Manager;
using CVAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CVAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CVItemsController : ControllerBase
    {
        private readonly CVItemManager _manager = new CVItemManager();

        // GET: api/<CVItemsController>
        [HttpGet]
        public List<CVItem> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<CVItemsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST api/<CVItemsController>
        [HttpPost]
        public void Post([FromBody] CVItem item)
        {
            _manager.Post(item);
        }

        // PUT api/<CVItemsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CVItem item)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<CVItemsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _manager.Delete(id);
        }

        [HttpGet]
        [Route("cat/{categoryName}")]
        public List<CVItem>GetByCat(string categoryName)
        {
            return _manager.GetByCategory(categoryName);
        }
    }
}
