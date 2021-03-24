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

        public SkillManager()
        {
            var testSkill = new Skill(1, "Advanced C#");
            var testSkill2 = new Skill(2, "MSSQL");
            var testSkill3 = new Skill(3, "Agile Development (SCRUM, XP)");
            Post(testSkill);
            Post(testSkill2);
            Post(testSkill3);
        }

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
