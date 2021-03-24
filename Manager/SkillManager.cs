using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVAPI.Models;

namespace CVAPI.Manager
{
    public class SkillManager
    {
        private static readonly List<Skill> Skills = new List<Skill>
        {
            new Skill(1, "Advanced C#"),
            new Skill(2, "MSSQL"),
            new Skill(3, "Agile Development (SCRUM, XP)")
        };

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
            return Skills.Count > 0 ? Skills.Max(x => x.Id) + 1 : 1;
        }
    }
}
