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
            int skillAttack = 100;
            Console.WriteLine("You cast Fireball at the monster.");

            return skillAttack;
        }

        
    }
}
