using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubineTimothy_MonsterSlayer
{
    class Archer : Hero
    {

        public Archer(string name) : base(name, "Archer", 100, 15, 5)
        {

        }

        public override int Skill()
        {
            int SkillAttack = 75;
            return SkillAttack;
        }

    }
        
}
