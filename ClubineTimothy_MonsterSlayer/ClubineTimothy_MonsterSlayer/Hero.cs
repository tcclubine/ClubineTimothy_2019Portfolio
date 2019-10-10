﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubineTimothy_MonsterSlayer
{
    abstract class Hero 
    {
        private string mName;
        private List<Monster> mMonsterList;
        private int mHealth;
        private int mAttack;
        private int mArmor;
        

        public string Name { get { return mName; } set { mName = value; } }
        public int Health { get { return mHealth; }  }
        public int Attack { get { return mAttack; }  }
        public int Armor { get { return mArmor; }  }        
        public List<Monster> Monsters { get { return mMonsterList; } set { mMonsterList = value; } }

        public Hero(string name, int health, int attack, int armor)
        {
            mName = name;
            mHealth = health;
            mAttack = attack;
            mArmor = armor;
            
        }

        virtual public int Skill()
        {
            int temp = -1;
            Console.WriteLine("Error: This is the virtual Skill()");
            Console.ReadKey();
            return temp;
        }

        
    }
}
