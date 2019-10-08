using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubineTimothy_LogicLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Timothy Clubine
             SDI Section #01
             Logic Loops
             11-1-2018
             */

            //--------------------Problem #1 - Logical Operators: Making the Grade--------------------//

            //Greet the user 
            Console.WriteLine("Welcome to Making the Grade!\r\nLets find out if you passed!");

            //Create values to store the grades
            int grade1;
            int grade2;

            //Ask user for first grade
            Console.WriteLine("\r\nWhat is the first grade you received? Then press Enter:");

            //Catch user response for first grade
            string grade1String = Console.ReadLine();

            //Convert string to int and verify user response
            while (!int.TryParse(grade1String, out grade1) || grade1 < 0)
            {
                //Tell user what went wrong
                Console.WriteLine("Sorry, I didn't catch that.\r\nPlease enter your grade:");
                //Re-catch user response
                grade1String = Console.ReadLine();
                int.TryParse(grade1String, out grade1);
            }

            //Ask user for second grade
            Console.WriteLine("What is the second grade you received? Then press Enter:");

            //Catch user response for second grade
            string grade2String = Console.ReadLine();

            //Convert string to int and verify user response
            while (!int.TryParse(grade2String, out grade2) || grade2 < 0)
            {
                //Tell user what went wrong
                Console.WriteLine("Sorry, I didn't catch that.\r\nPlease enter your grade:");
                //Re-catch user response
                grade2String = Console.ReadLine();
                int.TryParse(grade2String, out grade2);
            }

            //Create array to store the grades
            int[] grades = new int[2] { grade1, grade2 };

            //create a condition that will check each grade in the array and determine if it is passing
            //Tell the user the results
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[0] > 70 && grades[1] > 70)
                {
                    //If both grades are higher than 70 
                    Console.WriteLine("\r\nCongrats, both grades are passing!");
                    break;
                }

                else
                {
                    //If one or more grades is failing
                    Console.WriteLine("\r\nOne or more grades are failing, try harder next time!");
                    break;

                }

                /*
                 Data Sets to Test:

                 Test #1: Grade1 = 95, Grade2 = 85, Results = "Congrats, both grades are passing!"
                 Test #2: Grade1 = 82, Grade2 = 68, Results = "One or more grades are failing, try harder next time!"
                 Test #3: Grade1 = Eighty (Computer should re-promt user),Grade1 = 80 Grade2 = 91, Results = "Congrats, both grades are passing!"
                 Test #4: Grade1 = 69, Grade2 = 70, Results = "One or more grades are failing, try harder next time!"
                */
            }

            //Thank the user for using the program
            Console.WriteLine("\r\nThank you for using Making the Grade!\r\nLets move on to the next problem. Hit any key to continue:");
            Console.ReadKey();
            Console.Clear();


            //--------------------Problem #2 - Logical Operators: Brunch Bunch--------------------//

            //Welcome the user
            Console.WriteLine("Welcome to Brunch Bunch!\r\n\r\nLets find out if you're eligible for a discount.");

            //ask user their age
            Console.WriteLine("Please tell me your age, then press Enter");

            //Catch user response for their age
            string ageString = Console.ReadLine();

            //Create int to hold user response
            int age;
            //create decimal to hold prices
            decimal seniorOrKid = 10.00m;
            decimal noDiscount = 15.00m;

            //Convert string to int and verify user response
            while (!int.TryParse(ageString, out age) || age <= 0)
            {
                //Tell the user what went wrong
                Console.WriteLine("Sorry I didn't catch that.\r\nPlease tell me your age as a number:");
                //re-catch user response
                ageString = Console.ReadLine();
                int.TryParse(ageString, out age);
            }
            if (age >= 55 || age < 10)
            {
                //user may receive discount
                Console.WriteLine("\r\nYour cost for brunch today is {0}", seniorOrKid.ToString("C"));
            }
            else
            {
                //Does not receive discount
                Console.WriteLine("\r\nYour cost for brunch today is {0}", noDiscount.ToString("C"));
            }
            /*
             Data Sets to Test:

            Test #1: Age=57, Results ="Your cost for brunch today is $10.00"
            Test #2: Age=39, Results ="Your cost for brunch today is $15.00"
            Test #3: Age=8, Results ="Your cost for brunch today is $10.00"
            Test #4: Age=10, Results ="Your cost for brunch today is $15.00"
            Test #5: Age=Fifty Five (Computer should re-prompt), Age=55, Results ="Your cost for brunch today is $10.00"

             */

            //Thank the user for using the program
            Console.WriteLine("\r\nThank you for using Brunch Bunch!\r\nLets move on to the next problem. Hit any key to continue:");
            Console.ReadKey();
            Console.Clear();


            //--------------------Problem #3 - For Loop: Add Them Up--------------------//

            //Greet the user
            Console.WriteLine("Welcome to Add Them Up!\r\nLets find out how many movies you own.");
            //Create variables for DVDs,Blue-Rays, and Digital UltraViolet
            int dvd;
            int blueRay;
            int ultraViolet;

            //ask user for number of DVD's
            Console.WriteLine("\r\nHow many DVD's do you own? Then press Enter:");

            //catch user response for DVD's
            string dvdString = Console.ReadLine();

            //convert to int and verify user response
            while (!int.TryParse(dvdString, out dvd) || dvd < 0)
            {
                //Tell user what went wrong
                Console.WriteLine("Sorry, I didn't catch that.\r\nType the number of DVD's you own:");
                //re-catch user response
                dvdString = Console.ReadLine();
                int.TryParse(dvdString, out dvd);

            }

            //ask user for number of blue-rays
            Console.WriteLine("How many Blu-Rays do you own? Then press Enter:");
            //catch user response for blue-rays
            string blueRayString = Console.ReadLine();

            //convert to int and vverify user response
            while (!int.TryParse(blueRayString, out blueRay) || blueRay < 0)
            {
                //Tell user what went wrong
                Console.WriteLine("Sorry, I didn't catch that.\r\nPlease type the number of Blue-Rays you own:");
                //re-catch user response
                blueRayString = Console.ReadLine();
                int.TryParse(blueRayString, out blueRay);

            }

            //ask user for number of ultraViolet movies
            Console.WriteLine("How many UltraViolet movies do you own? Then press Enter:");
            //catch user response for ultraViolet movies
            string ultraVioletString = Console.ReadLine();
            //convert to int and verify user response
            while (!int.TryParse(ultraVioletString, out ultraViolet) || ultraViolet < 0)
            {
                //tell the user what went wrong
                Console.WriteLine("Sorry, I didn't catch that.\r\nPlease type the number of UltraViolet movies you own:");
                //re-catch user response
                ultraVioletString = Console.ReadLine();
                int.TryParse(ultraVioletString, out ultraViolet);
            }

            //create array to hold user input
            int[] movies = new int[3] { dvd, blueRay, ultraViolet };
            //Create a variable to hold the sum of the array
            int moviesTotal = 0;

            //Creat for-loop to add up total number of movies
            foreach (int moviesArray in movies)
            {
                moviesTotal += moviesArray;

            }
            if (moviesTotal > 100)
            {
                Console.WriteLine("\r\nWow, I am impressed with your collection of {0} movies!", moviesTotal);
            }
            else
            {
                Console.WriteLine("\r\nYou have a total of {0} movies in your collection.", moviesTotal);
            }


            //Thank the user for using the program
            Console.WriteLine("\r\nThank you for using Add Them Up!\r\nLets move on to the next problem. Hit any key to continue:");
            Console.ReadKey();
            Console.Clear();


            //--------------------Problem #4 - While Loop: Cha-Ching!--------------------//

            //Greet  user
            Console.WriteLine("Welcome to Cha-Ching!\r\nLets see how many items we can buy with your gift card.");

            //ask user for gift card amount
            Console.WriteLine("\r\nHow much money do you have on your gift card? Then press Enter:");
            //catch user resonse for gift card amount
            string giftCardString = Console.ReadLine();
            //create variable to hold gift card string
            decimal giftCard;

            //convert string and verify user response
            while (!decimal.TryParse(giftCardString, out giftCard) || giftCard < 0)
            {
                //Tell the user what went wrong
                Console.WriteLine("Sorry, I didn't catch that. Please type the total amount you have on your gift card:");
                //re-catch user response
                giftCardString = Console.ReadLine();
                decimal.TryParse(giftCardString, out giftCard);
            }

            //creat a while loop to process the user's purchases
            do
            {
                //ask customer for cost of purchase
                Console.WriteLine("\r\nHow much is your purchase?");
                //catch user response
                string purchaseString = Console.ReadLine();
                //create variable to hold string
                decimal purchase;
                //convert string to decimal and verify response
                while (!decimal.TryParse(purchaseString, out purchase) || purchase <= 0)
                {
                    //tell the customer what went wrong
                    Console.WriteLine("Sorry, I didn't catch that.\r\nType the cost of your purchase:");
                    //re-catch user response
                    purchaseString = Console.ReadLine();
                    decimal.TryParse(purchaseString, out purchase);
                }
                //Have the purchase be subrtracted from the gift card
                giftCard -= purchase;

                //create condition for when the gift card reaches zero or a negative balance is due
                if (giftCard > 0)
                {
                    //Tell user how much is left of their gift card
                    Console.WriteLine("With your purchase of {0}, you can still spend {1}", purchase.ToString("C"), giftCard.ToString("C"));
                }
                else
                {
                    decimal giftCardBalance = giftCard * -1;
                    //Tell user how much they owe after using the gift card
                    Console.WriteLine("\r\nWith your last purchase of {0}, you have used your gift card up and still owe {1}.", purchase.ToString("C"), giftCardBalance.ToString("C"));
                }


            } while (giftCard > 0);

            /*
             Data Sets to use:

            Test #1: Gift Card amount= 30.00
                        Purchase1= 5.00
                            Results="With your current purchase of $5.00, you can still spend $25.00."
                        Purchase2= 10.50
                            Results= "With your current purchase of $10.50, you can still spend $14.50."
                        Purchase3= 16.00
                            Results= "With your last purchase of $16.00, you have used your gift card up and still owe $1.50."

            Test #2: Gift Card amount= 100.00
                        Purchase1= 49.99
                            Results="With your current purchase of $49.99, you can still spend $50.01."
                        Purchase2= 31.75
                            Results= "With your current purchase of $31.75, you can still spend $18.26."
                        Purchase3= 25.00
                            Results= "With your last purchase of $24.99, you have used your gift card up and still owe $6.74."
             
             
             
             
             */

            //Thank the user for using the program
            Console.WriteLine("\r\nThank you for running my program.\r\nYou have completed all the problems. Hooray!");
        }
    }
}
