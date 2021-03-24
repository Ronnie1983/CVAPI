using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVAPI.Models;

namespace CVAPI.Manager
{
    public class SkillManager
    {
        public static List<Skill> Skills = new List<Skill>();

        public List<Skill> GetAll()
        {
            return Skills;
        }

        public bool Post(Skill skill)
        {
            int beforeAdd = Skills.Count;
            skill.Id = AutoGenerateId();
            Skills.Add(skill);
            return beforeAdd + 1 == Skills.Count;
        }

        private int AutoGenerateId()
        {
            return Skills.Count > 0 ? Skills.Max(x => x.Id) : 1;
        }
    }
}
