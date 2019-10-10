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


            Title();
            MainMenu();
            do
            {
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "h":
                    case "create hero":
                    case "hero":

                        break;
                    case "c":
                    case "change class":
                    case "class":
                        break;
                    case "f":
                    case "fight monsters!":
                    case "fight":
                        break;
                    default:
                        Console.WriteLine($"\"{input}\" is not a valid command.");
                        Console.Write("Choose an option to continue: ");
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
        public static void MainMenu()
        {
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
