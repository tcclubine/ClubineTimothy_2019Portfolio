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

        public override int Skill(string s)
        {
            int skillAttack = -1;
            if (s == "attack")
            {
                Console.WriteLine("You cast Fireball at the monster.");
                skillAttack = 100;
            }
            else
            {
                Console.WriteLine("You cast Shield to protect yourself.");
                this.Status();
            }
            
            return skillAttack;
        }

        
    }
}
