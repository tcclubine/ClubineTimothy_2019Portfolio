using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubineTimothy_MonsterSlayer
{
    class Monster
    {
        private string mName;
        private string mDescription;
        private int mHealth;
        private int mAttack;
        private int mArmor;
        private int mSpecialAttackTurn;
        private string mPreAttackDescription;
        private string mSpecialAttackDescription;

        public string Name { get { return mName; } set { mName = value; } }
        public string Description { get { return mDescription; } set { mDescription = value; } }
        public int Health { get { return mHealth; } set { mHealth = value; } }
        public int Attack { get { return mAttack; } set { mAttack = value; } }
        public int Armor { get { return mArmor; } set { mArmor = value; } }
        public int SpecialAttackTurn { get { return mSpecialAttackTurn; } set { mSpecialAttackTurn = value; } }
        public string PreAttackDescription { get { return mPreAttackDescription; } set { mPreAttackDescription = value; } }
        public string SpecialAttackDescription { get { return mSpecialAttackDescription; } set { mSpecialAttackDescription = value; } }

        public Monster() {
            
        }

        public void MonsterAttack(Hero player, int turn) {
            if (mSpecialAttackTurn == turn -1)
            {
                Console.WriteLine(mPreAttackDescription);
            }
            if (mSpecialAttackTurn == turn)
            {
                Console.WriteLine(mSpecialAttackDescription);
                player.Health -= mAttack + 10;
            }
            else
            {
                player.Health -= mAttack;
            }
        }

        
    }
}
