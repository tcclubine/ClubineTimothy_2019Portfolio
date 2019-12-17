using System;
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

            //player.Status(null,null);

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
                        break;
                    case "c":
                    case "change class":
                    case "class":
                        if (PlayerNullCheck(player))
                        {
                            player = ChooseClass(player, player.Name);
                        }
                        break;
                    case "f":
                    case "fight monsters!":
                    case "fight":
                        if (PlayerNullCheck(player))
                        {
                            Fight(player);
                            foreach (Monster m in monsterList)
                            {
                                Console.WriteLine(m.Name);
                            }
                        }
                        break;
                    case "s":
                    case "save game":
                    case "save":
                        break;
                    case "l":
                    case "load game":
                    case "load":
                        break;
                    case "x":
                    case "exit":
                        programLoop = false;
                        break;
                    default:
                        Console.WriteLine($"\"{input}\" is not a valid command.");                        
                        break;
                }

                Console.WriteLine("Press to continue.");
                Console.ReadKey();
            } while (programLoop);

            Console.WriteLine("End of program.");
        }
        public static void Fight(Hero p)
        {

        }
        public static bool PlayerNullCheck(Hero p)
        {
            if (p == null)
            {
                Console.WriteLine("You must create a hero first.");
                return false;
            }
            else
            {
                return true;
            }            
            
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
            
            

            p = ChooseClass(p,name);


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

        public static void ClassMenu()
        {
            string menu =
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
                "[S] Save Game\r\n" +
                "[L] Load Game\r\n" +
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
