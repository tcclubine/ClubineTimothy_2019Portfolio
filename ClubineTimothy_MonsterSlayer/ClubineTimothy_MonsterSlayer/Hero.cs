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
        private bool mCanIBeAttacked;
        

        public string Name { get { return mName; } }
        public string ClassType { get { return mClassType; }  }
        public int Health { get { return mHealth; } set { mHealth = value; } }
        public int Attack { get { return mAttack; } set { mAttack = value; } }
        public int Armor { get { return mArmor; } set { mArmor = value; } }        
        public bool CanIBeAttacked { get { return mCanIBeAttacked; } }        

        public Hero(string name, string classType, int health, int attack, int armor)
        {
            mName = name;
            mClassType = classType;
            mHealth = health;
            mAttack = attack;
            mArmor = armor;            
            mCanIBeAttacked = true;
            
        }

        virtual public int Skill(string s)
        {
            int temp = -1;
            Console.WriteLine("Error: This is the virtual Skill()");
            Console.ReadKey();
            return temp;
        }

        public void Status()
        {
            mCanIBeAttacked = !mCanIBeAttacked;
        }


         
    }
}
