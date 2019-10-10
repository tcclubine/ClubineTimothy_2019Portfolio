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


            Title();

            
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
