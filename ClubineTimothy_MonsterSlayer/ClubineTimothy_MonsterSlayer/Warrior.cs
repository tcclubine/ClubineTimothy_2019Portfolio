using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubineTimothy_MonsterSlayer
{
    class Warrior : Hero, IStatusChange
    {
        private string mClassType;
        private bool mStatus;
        public string ClassType { get { return mClassType; } }

        public Warrior(string name) : base(name,"Warrior", 100, 10, 10)
        {
            mClassType = "Warrior";
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
