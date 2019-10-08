using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubineTimothyMadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Timothy Clubine
             SDI Section #01
             MadLibs
             10-26-2018
             */

            //Create Welcome message
            Console.WriteLine("Welcome to Mad Libs! Lets have some fun!");

            //Create inputs for the user to be used in the MadLib
            Console.WriteLine("Name a type of animal and press Enter");
            string animal = Console.ReadLine();

            Console.WriteLine("Give a Name and press Enter.");
            string name = Console.ReadLine();

            Console.WriteLine("Give an adjective and press Enter.");
            string adjective = Console.ReadLine();

            Console.WriteLine("Name a food item and press Enter.");
            string foodItem = Console.ReadLine();

            //The year, cost and randomNumber must be converted from a string datatype to a number datatype to meet the assignment goals.
            Console.WriteLine("Give a Year and press Enter.");
            string year = Console.ReadLine();
            int yearConvert = int.Parse(year);

            Console.WriteLine("Give a cost in money and press Enter."); 
            string cost = Console.ReadLine();
            double costConvert = int.Parse(cost);

            Console.WriteLine("Give a random number and press Enter.");
            string randomNumber = Console.ReadLine();
            int randomNumberConvert = int.Parse(randomNumber);

            //create an array for the number variables using the inputs from above
            double[] madLibs = new double[] {yearConvert, costConvert, randomNumberConvert};


            //Test inputs
            //Console.WriteLine(madLibs[0]); //year
            //Console.WriteLine(madLibs[1]); //cost
            //Console.WriteLine(madLibs[2]); //randomNumber

            //Create a story using the madLibs array.
            Console.WriteLine("\r\nA " + animal + " named " + name + " was " + adjective + " when a mysterious traveller aproached to sell a " + foodItem + ".");
            Console.WriteLine("The traveller said, \"it will give you blissful dreams while you sleep.\""+ " All the traveller asked for in exhange was " + madLibs[1].ToString("C") + ".");
            Console.WriteLine(name + " agreed and immediately ate the " + foodItem + ". It put " + name + " to sleep for " + madLibs[2] + " years.");
            Console.WriteLine("When " + name + " awoke, the year was " + madLibs[0]+" and the traveller stood over him with a sly smile. \"Did you enjoy your nap?\"");

        

        }
    }
}
