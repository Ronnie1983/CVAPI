using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVAPI.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Skill(string description)
        {
            Description = description;
        }
    }
}
