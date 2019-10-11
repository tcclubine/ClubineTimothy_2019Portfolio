using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubineTimothy_MonsterSlayer
{
    class Wizard : Hero, IStatusChange
    {
        private bool mStatus;
        public bool Status { get { return mStatus; } }

        public Wizard(string name) : base(name,"Wizard", 100, 5, 0)
        {
            mStatus = true;
        }

        public override int Skill()
        {
            int SkillAttack = 100;
            return SkillAttack;
        }

        void IStatusChange.Status()
        {
            mStatus = !mStatus;
        }
    }
}
