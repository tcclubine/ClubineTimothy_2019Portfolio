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
        

        public string Name { get { return mName; } set { mName = value; } }
        public string Description { get { return mDescription; } set { mDescription = value; } }
        public int Health { get { return mHealth; } set { mHealth = value; } }
        public int Attack { get { return mAttack; } set { mAttack = value; } }
        public int Armor { get { return mArmor; } set { mArmor = value; } }
        

        public Monster() {
            
        }

        public void MonsterAttack(Hero player, int turn) {
            int dmg = this.Attack - player.Armor;

            if (player.CanIBeAttacked)
            {
                if (player is Warrior)
                {
                    if (dmg < 1)
                    {
                        Console.WriteLine($"The {this.Name} cannot damage you. Your armor is too strong.");
                    }
                }
                else
                {
                    dmg = this.Attack - player.Armor;
                    Console.WriteLine($"You take {dmg} damage from the {this.Name}");
                    player.Health -= dmg;
                    
                }
            }
            else
            {
                if (player is Archer)
                {
                    Console.WriteLine($"You dodge the {this.Name}'s attack.");
                }
                
            }
            
        }

    }

}
