using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubineTimothyMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Timothy Clubine
             SDI Section #01
             11-4-2018
             Methods
             */

            //-------------------Problem #1: Currency Converter--------------------//

            //Greet user
            Console.WriteLine("Welcome to Currency Converter!" +
                "\r\nToday we are going to help you convert your Euros into American Dollars.\r\n");

            //ask user for amount to be converted
            Console.WriteLine("What is the amount in Euros you would like to convert?");

            //catch user response
            string eurosString = Console.ReadLine();

            //create decimal var to hold string
            decimal euros;

            //Convert and verify user response
            while (!decimal.TryParse(eurosString, out euros)||euros<0)
            {
                //Tell the user what went wrong
                Console.WriteLine("Please enter your Euros as a number:");
                //Re-catch user response
                eurosString = Console.ReadLine();
                decimal.TryParse(eurosString, out euros);
            }

            //Function call to convert Euros
            decimal conversion = EurosConversion(euros);

            //Tell the user the converted value in dollars
            Console.WriteLine("\r\n{0} euros converted to dollars is {1}.", euros, conversion.ToString("C"));

            /*
             Data Sets to Test:

             Test #1: Euros = 5.50
                        -Results = "5.50 euros converted to dollars is $6.38."

             Test #2: Euros = 15.32
                        -Results = "15.32 euros converted to dollars is $17.77."

             Test #2: Euros = 300.29
                        -Results = "300.29 euros converted to dollars is $348.34."

             */

            Console.WriteLine("\r\nLets move on to the next problem. Press any key to continue...");
            Console.ReadKey();
            Console.Clear();


            //-------------------Problem #2: Astronomical--------------------//

            //Greet User
            Console.WriteLine("Welcome to Astronomical" +
                "\r\n\r\nYou are an Astronaut floating through space and decided to conteplate what your weight would be on other planets." +
                "\r\nLet me help you out.");

            //Ask user for their weight
            Console.WriteLine("\r\nWhat is your current weight on Earth?");

            //Catch user response
            string userWeightString = Console.ReadLine();

            //set variable for userWeight
            double userWeight;

            //Convert string to double and verify user response
            while (!double.TryParse(userWeightString, out userWeight) || userWeight <= 0)
            {
                //Tell user what went wrong
                Console.WriteLine("Please enter your weight as a number:");
                //re-catch user response
                userWeightString = Console.ReadLine();
                double.TryParse(userWeightString, out userWeight);
            }

            //Ask the user to choose from a list of planets
            Console.WriteLine("Please choose a number from the list of planets below:\r\n" +
                "1-Mercury\r\n" +
                "2-Venus\r\n" +
                "3-Earth\r\n" +
                "4-Mars\r\n" +
                "5-Jupiter\r\n" +
                "6-Saturn\r\n" +
                "7-Uranus\r\n" +
                "8-Neptune\r\n");

            //Catch user response for planet picked
            string planetString = Console.ReadLine();

            //Hold variable for planet
            int planet;

            //Convert and verify user response
            while (!int.TryParse(planetString, out planet) || planet < 1 || planet > 8)
            {
                //Tell the user what went wrong
                Console.WriteLine("Please select a number 1-8 that corresponds with the selected planet:\r\n");
                //re-catch user response
                planetString = Console.ReadLine();
                int.TryParse(planetString, out planet);
            }
            //array to hold the planet names
            string[] planetNamesArray = new string[8] { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };


            //Create condition to output conversion of selected planet
            if (planet == 1)
            {
                double planet1 = .38;
                double mercury = WeightComparioson(userWeight, planet1);
                Console.WriteLine("On Earth you weigh {0} lbs, but on {1} you would weigh {2} lbs.", userWeight, planetNamesArray[0], mercury);
            }
            else if (planet == 2)
            {
                double planet2 = .91;
                double venus = WeightComparioson(userWeight, planet2);
                Console.WriteLine("On Earth you weigh {0} lbs, but on {1} you would weigh {2} lbs.", userWeight, planetNamesArray[1], venus);
            }
            else if (planet == 3)
            {
                double planet3 = 1;
                double earth = WeightComparioson(userWeight, planet3);
                Console.WriteLine("On Earth you weigh {0} lbs, but on {1} you would weigh {2} lbs.", userWeight, planetNamesArray[2], earth);
            }
            else if (planet == 4)
            {
                double planet4 = .38;
                double mars = WeightComparioson(userWeight, planet4);
                Console.WriteLine("On Earth you weigh {0} lbs, but on {1} you would weigh {2} lbs.", userWeight, planetNamesArray[3], mars);
            }
            else if (planet == 5)
            {
                double planet5 = 2.34;
                double jupiter = WeightComparioson(userWeight, planet5);
                Console.WriteLine("On Earth you weigh {0} lbs, but on {1} you would weigh {2} lbs.", userWeight, planetNamesArray[4], jupiter);
            }
            else if (planet == 6)
            {
                double planet6 = .93;
                double saturn = WeightComparioson(userWeight, planet6);
                Console.WriteLine("On Earth you weigh {0} lbs, but on {1} you would weigh {2} lbs.", userWeight, planetNamesArray[5], saturn);
            }
            else if (planet == 7)
            {
                double planet7 = .92;
                double uranus = WeightComparioson(userWeight, planet7);
                Console.WriteLine("On Earth you weigh {0} lbs, but on {1} you would weigh {2} lbs.", userWeight, planetNamesArray[6], uranus);
            }
            else
            {
                double planet8 = 1.12;
                double neptune = WeightComparioson(userWeight, planet8);
                Console.WriteLine("On Earth you weigh {0} lbs, but on {1} you would weigh {2} lbs.", userWeight, planetNamesArray[7], neptune);
            }

            /*
             Data Sets to Test:

             Test #1: Astronaught's Weight= 160, Planet Choice= 6
                        -Result = "On Earth you weigh 160 lbs, but on Saturn you would weigh 148.8 lbs."

             Test #1: Astronaught's Weight= 210, Planet Choice= 9(Re-prompt because not a valid choice), New Choice= 5
                        -Result = "On Earth you weigh 210 lbs, but on Jupiter you would weigh 491.4 lbs."

             Test #3: Astronaught's Weight= 231, Planet Choice= 3
                        -Result = "On Earth you weigh 231 lbs, but on Earth you would weigh 231 lbs."
             */

            Console.WriteLine("\r\nLets move on to the next problem. Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            //-------------------Problem #3: Substraction--------------------//

            //Welcome user
            Console.WriteLine("Welcome to Subtraction!\r\n" +
                "\r\nThere are 3 sets of test data for this problem." +
                "\r\nSelect which test arrays you would like to see, then comment out the other two." +
                "\r\nThe test results will print out below:\r\n");
            //Declare and define two arrays of at least 5 integer elements
            //Comment out Test #2 and Test #3 when testing #1 and vice versa
            //Data Sets to Test:

            //Test #1
            int[] firstArray = new int[5] { 4, 65, 32, 42, 12 };
            int[] secondArray = new int[5] { 1, 2, 5, 6, 9 };

            /*Results of test #1:
                4 - 1 is 3
                65 - 2 is 63
                32 - 5 is 27
                42 - 6 is 36
                12 - 9 is 3
             */

            ////Test #2
            ////Comment out Test #1 and #3
            //int[] firstArray = new int[6] { 54, 125, 96, 72, 45, 67 };
            //int[] secondArray = new int[6] { 87, 122, 145, 65, 3, 800 };

            /*Results of test #2:
                54 - 87 is -33
                125 - 122 is 3
                96 - 145 is -49
                72 - 65 is 7
                45 - 3 is 42
                67 - 800 is -733
             */

            ////Test #3
            ////Comment out Test #1 and #2
            //int[] firstArray = new int[6] { 28, 2, 22, 14, 7, 30 };
            //int[] secondArray = new int[6] { 2, 4, 4, 9, 10, 12 };

            /*Results of test #3:
                28 - 2 is 26
                2 - 4 is -2
                22 - 4 is 18
                14 - 9 is 5
                7 - 10 is -3
                30 - 12 is 18
             */

            //create a new array to catch results
            int[] newArray = ArraySubstraction(firstArray, secondArray);

            //output to console
            for (int z = 0, x = 0, y = 0; z < newArray.Length; z++, x++, y++)
            {
                Console.WriteLine("{0}-{1} is {2}.",firstArray[x],secondArray[y],newArray[z]);
            }


            Console.WriteLine("\r\nThank you for using my program. You have completed all the problems. Hooray!");
        }

        //-------------------Functions/Methods--------------------//

        //Function/Method for problem #1
        public static decimal EurosConversion(decimal e) {
            //convert Euros to Dollar
            decimal dollar = e * (decimal)1.16;
            return dollar;
        }

        //Function/Method for problem #2
        public static double WeightComparioson(double userWeight, double planetChoice) {
            //calc weight of user on each planet
            double weightConversion = userWeight * planetChoice;
            return weightConversion;
        }

        //Function/Method for problem #3
        //Create a function that will subtract the matching array elements from each other and store the values in an array
        public static int[] ArraySubstraction(int[] firstArray, int[] secondArray)
        {
            int N = firstArray.Length;
            //create a blank array of the same length as the incoming arrays
            int[] blankArray = new int[N];

            //sort through arrays
            for (int z = 0, x = 0, y = 0; z < blankArray.Length; z++, x++, y++)
            {
                blankArray[z] = firstArray[x] - secondArray[y];

            }
            return blankArray;

        }


    }
}
