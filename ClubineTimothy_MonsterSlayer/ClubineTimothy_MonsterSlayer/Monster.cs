using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubineTimothy_MonsterSlayer
{
    class Monster : IStatusChange
    {
        private string mName;
        private string mDescription;
        private int mHealth;
        private int mAttack;
        private int mArmor;
        
        private bool mCanIAttack;
        private bool mCanIBeAttacked;

        public void Status(Hero p, Monster m)
        {
            if (p != null && m == null)
            {

            }
            else
            {

            }

        }

        
    }
}
