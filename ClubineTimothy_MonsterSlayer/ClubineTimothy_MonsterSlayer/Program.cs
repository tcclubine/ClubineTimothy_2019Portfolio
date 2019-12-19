﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubineTimothy_MonsterSlayer
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
             Timothy Clubine
             WDD229-O
             Final Project
             10/10/2019
             */

            Hero player = null;
            List<Monster> monsterList = null;
            JSON json = new JSON();
            monsterList = json.CreateMonsterList();

            bool programLoop = true;
            do
            {
                Console.Clear();
                Title();
                MainMenu(player);
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "h":
                    case "create hero":
                    case "hero":
                        player = CreateHero(player);
                        PressToContinue();
                        break;
                    case "c":
                    case "change class":
                    case "class":
                        if (PlayerNullCheck(player))
                        {
                            player = ChooseClass(player, player.Name);
                            PressToContinue();
                        }                        
                        break;
                    case "f":
                    case "fight monsters!":
                    case "fight":
                        if (PlayerNullCheck(player) )
                        {
                            if (monsterList.Count > 0)
                            {
                                monsterList = Fight(player, monsterList);
                            }
                            else
                            {
                                Console.WriteLine("The monsters have respawned.");
                                PressToContinue();
                                monsterList = json.CreateMonsterList();
                                monsterList = Fight(player, monsterList);
                            }
                            
                        }
                        break;
                    case "x":
                    case "exit":
                        programLoop = false;
                        break;
                    default:
                        DefaultMenuMessage(input);
                        PressToContinue();
                        break;
                }

                
            } while (programLoop);

            Console.WriteLine("End of program.");
        }
        public static Hero CreateHero(Hero p)
        {
            string name = null;
            do
            {
                if (p == null)
                {
                    Console.Write("Enter a name for your Hero: ");
                    name = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("Do not leave blank. ");
                    }
                }
                else
                {
                    Console.WriteLine("Warning! This will override your current Hero.");
                    Console.Write("Proceed? (y/n): ");
                    string input = Console.ReadLine().ToLower();
                    switch (input)
                    {
                        case "y":
                        case "yes":
                            p = null;
                            break;
                        case "n":
                        case "no":
                            return p;
                        default:
                            break;
                    }
                }

            } while (string.IsNullOrWhiteSpace(name));



            p = ChooseClass(p, name);


            return p;
        }
        public static Hero ChooseClass(Hero p, string name)
        {

            do
            {
                ClassMenu();
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "w":
                    case "warrior":
                        p = new Warrior(name);
                        return p;
                    case "a":
                    case "archer":
                        p = new Archer(name);
                        return p;
                    case "z":
                    case "wizard":
                        p = new Wizard(name);
                        return p;
                    default:
                        Console.WriteLine($"\"{input}\" is not an available class.");
                        break;
                }

            } while (true);

        }
        public static List<Monster> Fight(Hero player, List<Monster> mList)
        {

            bool fightLoop = true;
            int dmg = -1;
            // turn counter
            int turn = 1;
            do
            {
                Monster m = mList[0];
                bool menuLoop = true;
                do
                {
                    menuLoop = false;
                    Console.Clear();
                    Console.WriteLine($"{player.Name}'s Health: {player.Health}");
                    // Declare monster to player
                    Console.WriteLine(m.Description);
                    Console.WriteLine("------FIGHT!------");
                    FightMenu();

                    // create player turn
                    string input = Console.ReadLine().ToLower();
                    switch (input)
                    {
                        case "a":
                        case "attack":
                            dmg = player.Attack - m.Armor;
                            DamageCalc(dmg, m);

                            break;
                        case "s":
                        case "use skill":
                        case "skill":
                            dmg = player.Skill() - m.Armor;
                            DamageCalc(dmg, m);
                            break;
                        case "r":
                        case "run away":
                        case "run":
                            Console.WriteLine($"You successfully ran away. The {m.Name} regains it's health while it waits for your return.");
                            m.Health = 100;
                            player.Health = 100;
                            fightLoop = false;
                            PressToContinue();
                            break;
                        default:
                            menuLoop = true;
                            DefaultMenuMessage(input);
                            PressToContinue();
                            break;
                    }

                } while (menuLoop);

                if (m.Health < 1)
                {
                    Console.WriteLine($"You have slain the {m.Name}!");
                    turn = 1;
                    mList.RemoveAt(0);
                    PressToContinue();
                }
                else
                {
                    if (fightLoop)
                    {
                        // create monster turn
                        m.MonsterAttack(player, turn);
                        PressToContinue();
                        if (player.Health < 1)
                        {
                            Console.WriteLine("You have died.");
                            PressToContinue();
                            fightLoop = false;
                            m.Health = 100;
                            player.Health = 100;

                        }
                        // resolve turn
                        turn += 1;
                        if (!player.CanIBeAttacked)
                        {
                            player.Status();
                        }

                    }

                }


            } while (fightLoop && mList.Count > 0);

            if (mList.Count < 1 && player.Health > 0)
            {
                Console.WriteLine("Congratulations! You have slain all of the monsters.");
                PressToContinue();
            }

            return mList;
        }
        public static void DamageCalc(int dmg, Monster m) {
            if (dmg < 1)
            {
                Console.WriteLine($"You do no damage. The {m.Name}'s armor is too strong.");
                PressToContinue();
            }
            else
            {
                Console.WriteLine($"You do {dmg} damage to the {m.Name}.");
                PressToContinue();
                m.Health -= dmg;
            }
        }

        public static void DefaultMenuMessage(string input)
        {
            Console.WriteLine($"\"{input}\" is not a valid command.");
        }
        public static void PressToContinue() {
            Console.WriteLine("Press to continue.");
            Console.ReadKey();
        }
        public static bool PlayerNullCheck(Hero p)
        {
            if (p == null)
            {
                Console.WriteLine("You must create a hero first.");
                PressToContinue();
                return false;
            }
            else
            {
                return true;
            }            
            
        }

        public static void FightMenu()
        {
            string fMenu =
                "[a] Attack \r\n" +
                "[s] Use Skill \r\n" +
                "[r] Run Away \r\n" +
                "-----------------------------\r\n" +
                "Choose an action: ";
            Console.Write(fMenu);
        }
        public static void ClassMenu()
        {
            string menu =
                "-----------" +
                "   Class   " +
                "-----------\r\n" +
                "[W] Warrior \r\n" +
                "[A] Archer \r\n" +
                "[Z] Wizard \r\n" +
                "---------------\r\n" +
                "Choose a class: ";
            Console.Write(menu);
        }
        public static void MainMenu(Hero p)
        {
            if (p != null)
            {
                Console.WriteLine($"Welcome {p.Name} the {p.ClassType}!\r\n");
            }
            Console.Write(                
                "[H] Create Hero\r\n" +
                "[C] Change Class\r\n" +
                "[F] Fight Monsters!\r\n" +
                "\r\n" +
                "[X] Exit\r\n" +
                "---------------------------------------------\r\n" +
                "Choose an option to continue: "
                );
        }
        public static void Title()
        {
            string title = " __  __                 _               _____ _                                     \r\n" +
                           "|  \\/  |               | |             / ____| |                                   \r\n" +
                           "| \\  / | ___  _ __  ___| |_ ___ _ __  | (___ | | __ _ _   _  ___ _ __              \r\n" +
                           "| |\\/| |/ _ \\| '_ \\/ __| __/ _ \\ '__|  \\___ \\| |/ _` | | | |/ _ \\ '__|       \r\n" +
                           "| |  | | (_) | | | \\__ \\ | | __/ |     ____) | | (_| | |_| | |__/ |               \r\n" +
                           "|_|  |_|\\___/|_| |_|___/\\__\\___|_|    |_____/|_|\\__,_|\\__, |\\___|_|           \r\n" +
                           "                                                       __/ |                        \r\n" +
                           "                                                      |___/                         \r\n" +
                           "__________________________________________________________________________          \r\n";

            Console.WriteLine(title);
        }
    }
}
