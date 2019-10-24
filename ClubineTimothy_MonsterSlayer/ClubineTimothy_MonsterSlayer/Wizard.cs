using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubineTimothy_MonsterSlayer
{
    class Wizard : Hero
    {
        

        public Wizard(string name) : base(name,"Wizard", 100, 5, 0)
        {
            
        }

        public override int Skill()
        {
            int SkillAttack = 100;
            return SkillAttack;
        }

        
    }
}
