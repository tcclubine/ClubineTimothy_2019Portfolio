using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubineTimothyGroceryCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Timothy Clubine
             SDI Section #01
             Grocery Calc
             10-24-2018
             */

            //Welcoming message to the user
            Console.WriteLine("Welcome to GroceryCalc!"+"\r\nPlease follow the instructions below to find out the cost of your grocery list.");

            //Ask user for type of item
            Console.WriteLine("\r\nWhat is the first item in your grocery cart?");
            string item1 = Console.ReadLine();

            //Ask user for the cost of first item
            Console.WriteLine("\r\nPlease enter the cost for each "+item1+" and press Enter.");
            string item1Cost = Console.ReadLine();

            //Convert the string item1Cost to double
            double item1Convert = double.Parse(item1Cost);

            //Ask the user for the total number of item1
            Console.WriteLine("Please enter the total number of " + item1 + "s you have and press Enter.");
            string item1Total = Console.ReadLine();

            //Convet string item1Total to int
            int item1Number = int.Parse(item1Total);

            //Find the total cost of the item1
            //item1Number*item1Convert
            double item1TotalCost = item1Number * item1Convert;

            //User receives total cost of first item
            //Test 
            Console.WriteLine("Total cost of the "+ item1 + "s before tax is "+ item1TotalCost.ToString("C"));

            //Copy and paste previous code for each additional item(apples,steaks,and Ice Cream)

            //---------------------------------------item2------------------------------------------------------
            
            //Change code to reflect new item. i.e item2, item3, etc.

            //Ask user for next type of item
            Console.WriteLine("\r\nWhat is the next item in your grocery cart?");
            string item2 = Console.ReadLine();

            //Ask user for the cost of item2
            Console.WriteLine("\r\nPlease enter the cost for each " + item2 + " and press Enter.");
            string item2Cost = Console.ReadLine();

            //Convert the string item2Cost to double
            double item2Convert = double.Parse(item2Cost);

            //Ask the user for the total number of item2
            Console.WriteLine("Please enter the total number of " + item2 + "s you have and press Enter.");
            string item2Total = Console.ReadLine();

            //Convet string item2Total to int
            int item2Number = int.Parse(item2Total);

            //Find the total cost of item2
            //item2Number*item2Convert
            double item2TotalCost = item2Number * item2Convert;

            //User receives total cost for items
            //Test 
            //Console.WriteLine("Total cost of the "+ item1 + "s before tax is "+item1TotalCost.ToString("C"));
            //Console.WriteLine("Total cost of the " + item2 + "s before tax is " + item2TotalCost.ToString("C"));

            //---------------------------------------item3--------------------------------------------------------


            //Ask user for next type of item
            Console.WriteLine("\r\nWhat is the next item in your grocery cart?");
            string item3 = Console.ReadLine();

            //Ask user for the cost of item3 item
            Console.WriteLine("\r\nPlease enter the cost for each " + item3 + " and press Enter.");
            string item3Cost = Console.ReadLine();

            //Convert the string item3Cost to double
            double item3Convert = double.Parse(item3Cost);

            //Ask the user for the total number of item3
            Console.WriteLine("Please enter the total number of " + item3 + "s you have and press Enter.");
            string item3Total = Console.ReadLine();

            //Convet string item3Total to int
            int item3Number = int.Parse(item3Total);

            //Find the total cost of item3
            //item3Number*item3Convert
            double item3TotalCost = item3Number * item3Convert;

            //User receives total cost for items
            //Test 
            //Console.WriteLine("Total cost of the "+ item1 + "s before tax is "+item1TotalCost.ToString("C"));
            //Console.WriteLine("Total cost of the " + item2 + "s before tax is " + item2TotalCost.ToString("C"));
            //Console.WriteLine("Total cost of the " + item3 + "s before tax is " + item3TotalCost.ToString("C"));

            //------------------------------------End of item list------------------------------------------------


            //Calculate total costs of the grocery cart with tax
            //Ask customer for sales tax
            Console.WriteLine("\r\nThank you." + "\r\nPlease enter the tax % in your area");
            string tax = Console.ReadLine();

            //Convert string tax to double
            double taxConvert = double.Parse(tax);
            //Change % to Decimal
            taxConvert /= 100;

            //Farewll to user and results
            Console.WriteLine("\r\nThank you for using GroceryCalc. Your costs have been itemized below:");

            //User results
            //User receives itemized list of items, total cost before tax, sales tax total, total cost with sales tax
            //
            Console.WriteLine("Total cost of the "+ item1 + "s before tax is "+ item1TotalCost.ToString("C"));
            Console.WriteLine("Total cost of the " + item2 + "s before tax is " + item2TotalCost.ToString("C"));
            Console.WriteLine("Total cost of the " + item3 + "s before tax is " + item3TotalCost.ToString("C"));

            //Total cost of items before tax
            double totalCost = item1TotalCost + item2TotalCost + item3TotalCost;
            Console.WriteLine("Total cost of all items before tax is "+totalCost.ToString("C"));

            //Calculate tax of all items
            //(totalCost)*taxConvert
            double taxTotal = (totalCost) * taxConvert;
            Console.WriteLine("Total sales tax on all items is "+ taxTotal.ToString("C"));

            //Calculate total cost including tax
            //taxTotal+totalCost
            double totalWithTax = taxTotal + totalCost;

            //Give user final cost with tax
            Console.WriteLine("Total of all items including tax is "+ totalWithTax.ToString("C"));

            //This program used two test to ensure accuracr using the inputs below
            /*
             Inputs for test #1
             - Name of item1: Apple
             - Name of item2: Steak
             - Name of item3: Ice Cream

             - Cost of item1: 0.50
             - Cost of item2: 15.25
             - Cost of item3: 5.75

             - Quantity of item1: 4
             - Quantity of item2: 2
             - Quantity of item3: 1

             - Sales Tax in My Area: 7

             Results
             - Total cost of Apples before tax is $2.00
             - Total cost of Steaks before tax is $30.50
             - Total cost of Ice Creams before tax is $5.75
             - Total cost of all items before tax is $38.25
             - Total sales tax on all items is $2.68
             - Total of all items including sales tax is $40.93

             Inputs of test #2
             - Name of item1: Apple
             - Name of item2: Steak
             - Name of item3: Ice Cream

             - Cost of item1: 0.75
             - Cost of item2: 13.24
             - Cost of item3: 3.75

             - Quantity of item1: 6
             - Quantity of item2: 4
             - Quantity of item3: 2

             - Sales Tax in My Area: 9
             
             Results
             - Total cost of Apples before tax is $4.50
             - Total cost of Steaks before tax is $52.96
             - Total cost of Ice Creams before tax is $7.50
             - Total cost of all items before tax is $64.96
             - Total sales tax on all items is $5.85
             - Total of all items including sales tax is $70.81
             */

        }
    }
}
