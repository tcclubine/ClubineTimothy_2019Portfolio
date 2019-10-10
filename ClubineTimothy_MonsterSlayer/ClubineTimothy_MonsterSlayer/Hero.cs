using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubineTimothy_MonsterSlayer
{
    abstract class Hero : StatusChange
    {
        private string mName;
        private List<Monster> mMonsterList;
        private int mHealth;
        private int mAttack;
        private int mArmor;
        private bool mStatus;

        public string Name { get { return mName; } set { mName = value; } }
        public int Health { get { return mHealth; }  }
        public int Attack { get { return mAttack; }  }
        public int Armor { get { return mArmor; }  }
        public bool Status { get { return mStatus; } }
        public List<Monster> Monsters { get { return mMonsterList; } }

        public Hero(string name, int health, int attack, int armor)
        {
            mName = name;
            mHealth = health;
            mAttack = attack;
            mArmor = armor;
            mStatus = true;
        }

        virtual public int Skill()
        {
            int temp = -1;
            Console.WriteLine("Error: This is the virtual Skill()");
            Console.ReadKey();
            return temp;
        }

        void StatusChange.Status()
        {
            mStatus = !mStatus;
        }
    }
}
