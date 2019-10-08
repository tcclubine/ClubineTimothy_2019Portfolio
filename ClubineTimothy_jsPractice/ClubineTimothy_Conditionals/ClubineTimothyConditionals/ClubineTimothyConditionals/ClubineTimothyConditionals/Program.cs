using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubineTimothyConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Timothy Clubine
             10-30-2018
             Conditionals
             Section #01
             */

            
            //------------------------------Problem #1: Hit the Jackpot!------------------------------//

            //Greet user
            Console.WriteLine("Congratulations you have won the lottery!" +
                "\r\nWe will now calculate how much your actual total winnings will be.You have two options:" +
                "\r\nThe first option is a lump sum one-time payment. If you do this you will only receive 85% of your total winnings." +
                "\r\nThe second option is to take 20 annual payments but you take the full amount.");

     
            //Ask user how much they won
            Console.WriteLine("What is your total amount of winnings and press Enter.");

            //Catch user input
            string winningString = Console.ReadLine();
            decimal winnings;

            //Convert winningString to decimal and validate
            while (!decimal.TryParse(winningString, out winnings) || (winnings <= 0))
            {
                //Tell user what is happening
                Console.WriteLine("Sorry, I didn't understand that.\r\nPlease enter your winnings:");
                //Re-catch user response
                winningString = Console.ReadLine();
                decimal.TryParse(winningString, out winnings);


            }

            //User winnings
            Console.WriteLine("\r\nCongratulations on winning ${0}" +
                "!\r\nHow would you like to receive your winnings?" +
                "\r\nTo receive the lump sum, type L and press Enter,  or" +
                "\r\nto receive annual payments, type A and press Enter.", winnings);

            //Catch user response
            string decision = Console.ReadLine();

            

            while (string.IsNullOrWhiteSpace(decision) || (decision !="L" && decision !="l" && decision !="A" && decision !="a")) {
                Console.WriteLine("Sorry, I didn't understand that." +
                    "\r\nType L for a lump sum or type A for annual payments and press Enter:");
                decision = Console.ReadLine();
            }

            //User's decision is:
            //Tell user how they will receive their winnings
            //Define and declare winnings for lump sum and annual
            decimal lumpSum = winnings * .85m;
            decimal annual = winnings / 20M;
            
            //Create conditional based off user decision and give results
            if (decision == "L" || decision == "l")
            {
                Console.WriteLine("Your winnings of ${0} as a one-time lump sum payment is ${1}.",winnings, lumpSum);
            }
            else {
                Console.WriteLine("Your winnings of ${0} will be paid in 20 payments of ${1} a year.",winnings,annual);
            }

            /*
             Test data sets used:

             Test 1: Winnings = 20000, Payment Option = "A"
                     -Results = "Your winnings of $20000 will be paid in 20 payments of $1000 a year."

             Test 2: Winnings = 100000.50, Payment Option = "L"
                     -Results = "Your winnings of $100000.50 as a one-time lump sum payment is $85000.4250."

             Test 3: Winnings = 65000000.99, Payment Option = "a"
                     -Results = "Your winnings of $65000000.99 will be paid in 20 payments of $3250000.0495 a year."

             Test 4: Winnings = 1600000000, Payment Option = "l"
                     -Results = "Your winnings of $1600000000 as a one-time lump sum payment is $1360000000.00."
             */

           
           //The code used to clear the console was used in the assignment FindErrorsCond
           //I thought it would be useful for going through multiple problems
           Console.WriteLine("\r\nLets move on to the next problem. Press any key to continue:");
           Console.ReadKey();
           Console.Clear();


           
           //------------------------------Problem #2: Lets make a deal------------------------------//

           //Greet user with new problem
           Console.WriteLine("Welcome to Lets make a deal!\r\n\r\nLets find out if buying in bulk is better than using your coupon for a individual item.");

           //Ask user for how many items are in the bulk pack
           Console.WriteLine("How many items are in your bulk pack? Then press Enter");

           //Catch response for number of items in the bulk pack
           string bulkItemSting = Console.ReadLine();
           //Create int to store string
           int bulkItemNumber;

           //Create condition to convert and verify user response
           while (!int.TryParse(bulkItemSting, out bulkItemNumber)|| bulkItemNumber<=0) {
               Console.WriteLine("Sorry, I didn't catch that." +
                   "\r\nPlease type the number of items in your bulk pack:");
               //Re=catch user response
               bulkItemSting = Console.ReadLine();
               int.TryParse(bulkItemSting, out bulkItemNumber);
           }
           
           //Ask the user for the cost of the bulk pack
           Console.WriteLine("How much does the bulk pack cost? Then press Enter");

           //catch response for bulk pack price
           string bulkPriceString = Console.ReadLine();

           //create decimal to store string
           decimal bulkPackPrice;

           //Create condition to convert and verify user response
           while (!decimal.TryParse(bulkPriceString, out bulkPackPrice)  || bulkPackPrice<=0) {
               Console.WriteLine("Sorry, I didn't catch that." +
                   "\r\nPlease type the cost of the bulk item and press Enter:");
               //Re-catch user response
               bulkPriceString = Console.ReadLine();
               decimal.TryParse(bulkPriceString, out bulkPackPrice);
           }
           
           //Calculate the cost of each item in the bulk pack
           decimal bulkPackItemPrice = bulkPackPrice / bulkItemNumber;

           //Find out the cost of the individual item (Not part of the bulk pack!)
           Console.WriteLine("\r\nWhat is the cost of an individual item? Then press Enter");

           //catch response for individual item
           string itemCostString = Console.ReadLine();

           //Create decimal to store string
           decimal itemCost;

           //Create condition to convert and verify user response
           while (!decimal.TryParse(itemCostString, out itemCost)|| itemCost<=0) {
               Console.WriteLine("Sorry, I didn't catch that." +
                   "\r\nPlease type the cost of the individual item:");
               //Re-catch user response
               itemCostString = Console.ReadLine();
               decimal.TryParse(itemCostString, out itemCost);

           }
           
           //Ask user for coupon amount off
           Console.WriteLine("How much will the coupon take off of the individual item? Then press Enter");

           //Catch response of coupon amount off
           string couponString = Console.ReadLine();

           //Create decimal to store string
           decimal coupon;

           //Create condition to convert and verify user response
           while (!decimal.TryParse(couponString, out coupon)||coupon <=0) {
               Console.WriteLine("Sorry, I didn't catch that." +
                   "\r\nPlease type how much the coupon will take off of your item, then press Enter");
               //Re-catch user response
               couponString = Console.ReadLine();
               decimal.TryParse(couponString, out coupon);

           }
           
           //Calculate cost of single item with the coupon
           decimal itemCostWithCoupon = itemCost - coupon;

           //Create a condition where if (the cost of 1 item in the bulk pack < the cost of the single item with couple, buy the bulk pack
           //else buy the single item with coupon

           if (bulkPackItemPrice < itemCostWithCoupon)
           {
               Console.WriteLine("The cost of 1 item in the bulk pack is ${0}, which is cheaper than the cost of the individual item with coupon, which is ${1}" +
                   "\r\n\r\nBUY THE BULK PACK!\r\n", bulkPackItemPrice, itemCostWithCoupon);
           }
           else {
               Console.WriteLine("The cost of 1 item using the coupon is ${0}, which is cheaper than the cost of the individual item from the bulk pack, which is ${1}." +
                   "\r\n\r\nBUY THE INDIVIDUAL ITEM AND USE THE COUPON!\r\n",itemCostWithCoupon,bulkPackItemPrice);
           }

           /*Test Data Sets used:

             Test 1:  Number of items in bulk pack = 50
                      Cost of bulk pack = 100.00
                      The cost of the individual item = 4.50
                      Coupon Value = 1.00

                      Result = "The cost of 1 item in the bulk pack is $2.00, which is cheaper than the cost of the individual item with coupon, which is $3.50
                                 BUY THE BULK PACK!"

             Test 2:  Number of items in bulk pack = 20
                      Cost of bulk pack = 80.50
                      The cost of the individual item = 6.25
                      Coupon Value = 2.25

                      Result = "The cost of 1 item using the coupon is $4.00, which is cheaper than the cost of the individual item from the bulk pack, which is $4.025.
                               BUY THE INDIVIDUAL ITEM AND USE THE COUPON!"

             Test 3:  Number of items in bulk pack = 16
                      Cost of bulk pack = 9.99
                      The cost of the individual item = 1.00
                      Coupon Value = .20

                      Result = "The cost of 1 item in the bulk pack is $0.624375, which is cheaper than the cost of the individual item with coupon, which is $0.80
                               BUY THE BULK PACK!"
           */
            
            //The code used to clear the console was used in the assignment FindErrorsCond
            //I thought it would be useful for going through multiple problems
            Console.WriteLine("\r\nLets move on to the next problem. Press any key to continue:");
            Console.ReadKey();
            Console.Clear();
            

            
            //------------------------------Problem #3: Pumpkin Patch Pickers------------------------------//

            //Greet user with new problem
            Console.WriteLine("Welcome to Pumpkin Patch Pickers!\r\nLets find the cost of your pumpkin.\r\n");

            //Ask the user for the weight of their pumpkin
            Console.WriteLine("What is the weight of your pumpkin? Then press Enter");

            //Catch user response for the weight of the pumpkin
            string pumpkinWeightString = Console.ReadLine();

            //Create double to store string
            double pumpkinWeight;

            //Create condition to convert and verify user response
            while (!double.TryParse(pumpkinWeightString, out pumpkinWeight)|| pumpkinWeight<=0) {
                //Tell user what went wrong
                Console.WriteLine("Sorry, I didn't catch that. Please type in the weight of your pumpkin:");
                //Re-catch user response
                pumpkinWeightString = Console.ReadLine();
                double.TryParse(pumpkinWeightString, out pumpkinWeight);

            }
            
            //convert pumpkinWeight to decimal so it can be used to calculate cost
            decimal pumpkinWeightCost = (decimal)pumpkinWeight;

            //Create a condition to tell the user the cost of their pumpkin
            if (pumpkinWeight < 5.5) {
                //The cost of the pumpkin uo to 5.5 lbs.
                Console.WriteLine("Your pumpkin of {0} lbs. costs {1}", pumpkinWeight, (pumpkinWeightCost * 1.00m).ToString("C"));
            } else if (pumpkinWeight < 10.75) {
                //The cost of the pumpkin up to 10.75 lbs.
                Console.WriteLine("Your pumpkin of {0} lbs. costs {1}", pumpkinWeight, (pumpkinWeightCost * .90m).ToString("C"));
            } else if (pumpkinWeight < 25) {
                //The cost of the pumpkin up to 25 lbs.
                Console.WriteLine("Your pumpkin of {0} lbs. costs {1}", pumpkinWeight, (pumpkinWeightCost * .80m).ToString("C"));
            } else if (pumpkinWeight < 50) {
                //The cost of the pumpkin up to 50 lbs.
                Console.WriteLine("Your pumpkin of {0} lbs. costs {1}", pumpkinWeight, (pumpkinWeightCost * .70m).ToString("C"));
            } else if (pumpkinWeight <= 100) {
                //The cost of the pumpkin up to and including 100 lbs.
                Console.WriteLine("Your pumpkin of {0} lbs. costs ${1}", pumpkinWeight, (pumpkinWeightCost * .60m).ToString("C"));
            } else if (pumpkinWeight>100) {
                //The cost of the pumpkin above 100 lbs.
                Console.WriteLine("Your pumpkin of {0} lbs. costs ${1}", pumpkinWeight, (pumpkinWeightCost * .50m).ToString("C"));
            }

            /*
            Test Data Sets used:

            Test 1: Pumpkin Weight = 4.5
                    Result ="Your pumpkin of 4.5 lbs. costs $4.50"

            Test 2: Pumpkin Weight = 10
                    Result ="Your pumpkin of 10 lbs. costs $9.00"

            Test 3: Pumpkin Weight = 20.75
                    Result ="Your pumpkin of 20.75 lbs. costs $16.60"

            Test 4: Pumpkin Weight = 40
                    Result ="Your pumpkin of 40 lbs. costs $28.00"

            Test 5: Pumpkin Weight = 100
                    Result ="Your pumpkin of 100 lbs. costs $60.00"

            Test 6: Pumpkin Weight = 150.30
                    Result ="Your pumpkin of 150.3 lbs. costs $75.15"

            Test 7: Pumpkin Weight = 75.25
                    Result ="Your pumpkin of 75.25 lbs. costs $45.15"
             */

            
             //The code used to clear the console was used in the assignment FindErrorsCond
             //I thought it would be useful for going through multiple problems
             Console.WriteLine("\r\nLets move on to the next problem. Press any key to continue:");
             Console.ReadKey();
             Console.Clear();
             

            //------------------------------Problem #4: Loyalty Card------------------------------//

            //Greet user with new problem
            Console.WriteLine("Welcome to the Loyalty Card calculator.\r\nLets find the cost of your items\r\n");

            //Ask customer for cost of first item
            Console.WriteLine("What is the cost of your first item? Then press Enter");

            //Catch user respone for first item
            string item1String = Console.ReadLine();

            //Create decimal to stoer string
            decimal item1Cost;

            //Create condition to convert and verify user response
            while (!decimal.TryParse(item1String, out item1Cost)|| item1Cost<=0) {
                //Tell the user what happened
                Console.WriteLine("Sorry, I didn't catch that.\r\nPlease type in the cost of your first item:");
                //Re-Catch user response
                item1String = Console.ReadLine();
                decimal.TryParse(item1String, out item1Cost);
            }
            
            //Ask customer for cost of second item
            Console.WriteLine("What is the cost of your second item? Then press Enter");

            //Catch user respone for second item
            string item2String = Console.ReadLine();

            //Create decimal to stoer string
            decimal item2Cost;

            //Create condition to convert and verify user response
            while (!decimal.TryParse(item2String, out item2Cost)|| item2Cost<=0)
            {
                //Tell the user what happened
                Console.WriteLine("Sorry, I didn't catch that.\r\nPlease type in the cost of your second item:");
                //Re-Catch user response
                item2String = Console.ReadLine();
                decimal.TryParse(item2String, out item2Cost);
            }
            
            //Calculate the total cost of the two items
            decimal totalCost = item1Cost + item2Cost;
            //Calculate total cost with discount
            decimal totalCostDiscount = totalCost - (totalCost) * .15m;

            //ask the user if they are a preferred customer
            Console.WriteLine("Are you a Preferred Member? Then press Enter");

            //catch user response for preferred Customer
            string preferredMemberStatus = Console.ReadLine();

            //Verify user response
            while (string.IsNullOrWhiteSpace(preferredMemberStatus) || (preferredMemberStatus !="yes" && preferredMemberStatus != "Yes" && preferredMemberStatus != "YES" && preferredMemberStatus != "no" && preferredMemberStatus != "No" && preferredMemberStatus != "NO")) {
                //Tell user what went wrong
                Console.WriteLine("Sorry, I didn't catch that." +
                    "\r\rPlease type in Yes or No if you are a Preferred Member:");
                preferredMemberStatus = Console.ReadLine();
                string.IsNullOrWhiteSpace(preferredMemberStatus);
            }

            //Creat a condition that determines if the user gets a 15% discount
            if (preferredMemberStatus == "Yes" || preferredMemberStatus == "yes" || preferredMemberStatus == "YES")
            {
                //Calculate cost of the two items with a 15% discount and inform the user
                //(totalCost)*.15m +(totalCost)
                Console.WriteLine("Your total purchase is {0}, which includes your 15% discount.", totalCostDiscount.ToString("C") );
            }
            else {
                //tell user the total cost without the discount
                Console.WriteLine("Your total purchase is {0}.",totalCost.ToString("C"));
            }

            /*
             Test Data Sets used:

             Test 1: Cost of first item = 45.50
                     Cost of second item = 75.00
                     Preferred Member Status = "yes"
                     
                     Result ="Your total purchase is $102.43, which includes your 15% discount."

             Test 2: Cost of first item = 23.00
                     Cost of second item = 44.25
                     Preferred Member Status = "No"
                    
                     Result ="Your total purchase is $67.25."

             Test 3: Cost of first item = 1.25
                     Cost of second item = 18.99
                     Preferred Member Status = "YES"
                    
                     Result ="Your total purchase is $17.20, which includes your 15% discount."
             
             */
        }
    }
}

