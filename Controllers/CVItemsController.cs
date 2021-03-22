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
        private CVItemManager manager = new CVItemManager();

        // GET: api/<CVItemsController>
        [HttpGet]
        public List<CVItem> Get()
        {
            return manager.GetAll();
        }

        // GET api/<CVItemsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CVItemsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CVItemsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CVItemsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet]
        [Route("cat/{categoryName}")]
        public List<CVItem>GetByCat(string categoryName)
        {
            return manager.GetByCategory(categoryName);
        }
    }
}
