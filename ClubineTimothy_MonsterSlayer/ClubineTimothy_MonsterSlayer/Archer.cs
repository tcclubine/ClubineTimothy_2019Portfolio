using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubineTimothy_MonsterSlayer
{
    class Archer : Hero, IStatusChange
    {
        private bool mStatus;
        public bool Status { get { return mStatus; } }
        public Archer(string name) : base(name,"Archer", 100,15,5)
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
