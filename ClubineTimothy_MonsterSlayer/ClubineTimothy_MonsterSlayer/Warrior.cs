using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubineTimothy_MonsterSlayer
{
    class Warrior : Hero
    {
        

        public Warrior(string name) : base(name,"Warrior", 100, 10, 10)
        {            
            
        }

        public override int Skill(string s)
        {
            int SkillAttack = 50;
            return SkillAttack;
        }

        
    }
}
