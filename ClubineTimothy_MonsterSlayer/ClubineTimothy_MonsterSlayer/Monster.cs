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
            int dmg = this.Attack - player.Armor;

            if (this.SpecialAttackTurn == turn - 1)
            {
                Console.WriteLine(this.PreAttackDescription);
                Console.ReadKey();
            }

            if (player.CanIBeAttacked)
            {
                if (this.SpecialAttackTurn == turn)
                {
                    dmg = (this.Attack + 10) - player.Armor;
                    Console.WriteLine(mSpecialAttackDescription);
                    Console.WriteLine($"You take {dmg} damage from the {this.Name}");
                    player.Health -= dmg;
                }
                else
                {
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
                else if (player is Warrior)
                {
                    if (dmg < 1)
                    {
                        Console.WriteLine($"The {this.Name} cannot damage you. Your armor is too strong.");
                    }
                }
            }
            
        }

        
    }
}
