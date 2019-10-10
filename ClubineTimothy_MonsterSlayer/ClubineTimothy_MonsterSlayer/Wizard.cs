using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubineTimothy_MonsterSlayer
{
    class Wizard : Hero, IStatusChange
    {
        bool mStatus;

        public Wizard(string name, int health, int attack, int armor) : base(name, health, attack, armor)
        {
            mStatus = true;
        }

        public override int Skill()
        {
            int SkillAttack = 50;
            return SkillAttack;
        }

        void IStatusChange.Status()
        {
            mStatus = !mStatus;
        }
    }
}
