using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVAPI.Manager;
using CVAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CVAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SkillController : ControllerBase
    {
        private readonly SkillManager _manager = new SkillManager();
        [HttpGet]
        public List<Skill> GetAll()
        {
            return _manager.GetAll();
        }

        [HttpPost]
        public bool Post([FromBody] Skill skill)
        {
            return _manager.Post(skill);
        }
    }
}
