using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubineTimothy_MonsterSlayer
{
    abstract class Hero : IStatusChange
    {
        private string mName;
        private List<Monster> mMonsterList;
        private string mClassType;
        private int mHealth;
        private int mAttack;
        private int mArmor;
        private bool mCanIAttack;
        private bool mCanIBeAttacked;
        

        public string Name { get { return mName; } }
        public string ClassType { get { return mClassType; }  }
        public int Health { get { return mHealth; }  }
        public int Attack { get { return mAttack; }  }
        public int Armor { get { return mArmor; }  }
        public bool CanIAttack { get { return mCanIAttack; } }
        public bool CanIBeAttacked { get { return mCanIBeAttacked; } }
        public List<Monster> Monsters { get { return mMonsterList; } set { mMonsterList = value; } }

        public Hero(string name, string classType, int health, int attack, int armor)
        {
            mName = name;
            mClassType = classType;
            mHealth = health;
            mAttack = attack;
            mArmor = armor;
            mCanIAttack = true;
            mCanIBeAttacked = true;
            
        }

        virtual public int Skill()
        {
            int temp = -1;
            Console.WriteLine("Error: This is the virtual Skill()");
            Console.ReadKey();
            return temp;
        }

        public void Status(Hero p, Monster m)
        {
            if (p == null && m == null)
            {
                // reset monster status
                mCanIAttack = true;
                mCanIBeAttacked = true;

            }
            else if (p == null && m != null )
            {
                // Monster cannot attack
                mCanIAttack = false;
            }
            else if (p != null && m == null)
            {
                // Monster cannot be attacked
                mCanIBeAttacked = false;
            }
            else if (p != null && m != null)
            {

            }
            

        }
    }
}
