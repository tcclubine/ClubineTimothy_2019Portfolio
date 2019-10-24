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

        public string Name { get { return mName; } }
        public string Description { get { return mDescription; } }
        public int Health { get { return mHealth; } }
        public int Attack { get { return mAttack; } }
        public int Armor { get { return mArmor; } }
        public int SpecialAttackTurn { get { return mSpecialAttackTurn; } }
        public string PreAttackDescription { get { return mPreAttackDescription; } }
        public string SpecialAttackDescription { get { return mSpecialAttackDescription; } }

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
