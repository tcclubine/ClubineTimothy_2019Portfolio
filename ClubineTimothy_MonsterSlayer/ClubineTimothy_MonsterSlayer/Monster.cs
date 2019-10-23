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
        private int mAttackPattern;
        private string mPreAttackDescription;
        private string mSpecialAttackDescription;

        public Monster(string name, string description, int health, int attack, int armor, int attackPattern,string preAttackDescription, string specialAttackDescription) {
            mName = name;
            mDescription = description;
            mHealth = health;
            mAttack = attack;
            mArmor = armor;
            mAttackPattern = attackPattern;
            mPreAttackDescription = preAttackDescription;
            mSpecialAttackDescription = specialAttackDescription;
        }

        public void MonsterAttack(Hero player, int turn) {
            if (mAttackPattern == turn -1)
            {
                Console.WriteLine(mPreAttackDescription);
            }
            if (mAttackPattern == turn)
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
