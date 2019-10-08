// Create function to verify positive numbers from user input.
function validate(min, stm1, stm2){
    let stmCheck = stm1;
    let value;
    do
    {
        value = prompt(`${stm1}`);

        if (value === null){
            return value;
        }
        if ((value<min || isNaN(value) || value === "") && stm1 === stmCheck)
        {
            stm1 += `\r\n${stm2}`;
        }


    }while(value< min || isNaN(value)|| value === "");
    return value;
}


//------------------------------Problem #1: Hit the Jackpot!------------------------------//

//Greet user
    alert("Congratulations you have won the lottery!");

//Ask user how much they won
//Catch user input
//Validate user input
let winnings = validate(.01,"Enter the total amount of your winnings?","Enter a number greater than 0.");

if (winnings != null) {

    //Display User winnings
    alert(`Congratulations on winning \$${winnings}`+
        "\r\nWe will now calculate how much your actual total winnings will be." +
        "\r\n\r\nYou have two options:" +
        "\r\n1. A lump sum one-time payment where you'll receive 85% of the total winnings. " +
        "\r\n2. You will receive the full amount in 20 annual installments.");
    //Catch user response
    let decision = prompt(
        "How would you like to receive your winnings?" +
        "\r\nTo receive the lump sum, enter L ,  or" +
        "\r\nto receive annual payments, enter A.").toLocaleLowerCase();

    //User's decision is:
    //Tell user how they will receive their winnings
    //Define and declare winnings for lump sum and annual
    let lumpSum = winnings * .85;
    let annual = winnings / 20;
    let loop = true;

    while (loop)
    {
        //Create conditional based off user decision and give results
        switch(decision)
        {
            case "l":
            case "lump sum":
                loop = false;
                alert(`Your winnings of \$${winnings} as a one-time lump sum payment is \$${lumpSum.toFixed(2)}.`);
                break;
            case "a":
            case "annual":
                loop = false;
                alert(`Your winnings of \$${winnings} will be paid in 20 installments of \$${annual.toFixed(2)} a year.`);
                break;
            case null:
                loop = false;
                break;
            default:
                decision = prompt("Sorry, I didn't understand that." +
                    "\r\nEnter L for a lump sum or type A for annual payments.");
                break;
        }
    }
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
alert("\r\nLets move on to the next problem. Press ok to continue.");




//------------------------------Problem #2: Lets make a deal------------------------------//



//Greet user with new problem
alert("Welcome to Lets make a deal!" +
    "\r\n" +
    "\r\nLets find out if buying in bulk is better than using your coupon for a individual item.");

//Ask user for how many items are in the bulk pack
//Catch response for number of items in the bulk pack
//Create condition to convert and verify user response
let bulkItemNumber = validate(1,"How many items are in your bulk pack?","Please enter a number greater than 0.");
if (bulkItemNumber !== null) {
    //Ask the user for the cost of the bulk pack
    //Create condition to convert and verify user response
    let bulkPackPrice = validate(0,"How much does the bulk pack cost?", "Please enter the cost of the bulk item.");
    if (bulkPackPrice != null) {
        //Calculate the cost of each item in the bulk pack
        let bulkPackItemPrice = bulkPackPrice / bulkItemNumber;

        //Find out the cost of the individual item (Not part of the bulk pack!)
        //Create condition to convert and verify user response
        let itemCost = validate(0, "What is the cost of an individual item?","Please enter the cost of the individual item.");
        if (itemCost != null){
            //Ask user for coupon amount off
            //Create condition to convert and verify user response
            let coupon = validate(0,"How much will the coupon take off of the individual item?","Please enter the dollar amount that will be taken of the item.");


            //Calculate cost of single item with the coupon
            let itemCostWithCoupon = itemCost - coupon;

            //Create a condition where if (the cost of 1 item in the bulk pack < the cost of the single item with couple, buy the bulk pack
            //else buy the single item with coupon

            if (bulkPackItemPrice < itemCostWithCoupon)
            {
                alert(`The cost of 1 item in the bulk pack is \$${bulkPackItemPrice.toFixed(2)}, which is cheaper than the cost of the individual item with coupon, which is \$${itemCostWithCoupon.toFixed(2)}` +
                    "\r\n\r\nBUY THE BULK PACK!\r\n");
            }
            else {
                alert(`The cost of 1 item using the coupon is \$${itemCostWithCoupon.toFixed(2)}, which is cheaper than the cost of the individual item from the bulk pack, which is \$${bulkPackItemPrice.toFixed(2)}.` +
                    "\r\n\r\nBUY THE INDIVIDUAL ITEM AND USE THE COUPON!\r\n");
            }
        }
    }
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


alert("\r\nLets move on to the next problem. Press ok to continue:");




//------------------------------Problem #3: Pumpkin Patch Pickers------------------------------//

//Greet user with new problem
alert("Welcome to Pumpkin Patch Pickers!\r\nLets find the cost of your pumpkin.\r\n");

//Ask the user for the weight of their pumpkin
//Catch user response for the weight of the pumpkin
//Create condition to convert and verify user response
let pumpkinWeight;
pumpkinWeight = validate(.001, "What is the weight of your pumpkin?", "Enter a number greater than 0.");
if (pumpkinWeight != null){
    //Create a condition to tell the user the cost of their pumpkin
    if (pumpkinWeight < 5.5) {
        //The cost of the pumpkin up to 5.5 lbs.
        alert(`Your pumpkin of ${pumpkinWeight} lbs. costs \$${(pumpkinWeight * 1.00).toFixed(2)}.`);
    } else if (pumpkinWeight < 10.75) {
        //The cost of the pumpkin up to 10.75 lbs.
        alert(`Your pumpkin of ${pumpkinWeight} lbs. costs \$${(pumpkinWeight * .90).toFixed(2)}`);
    } else if (pumpkinWeight < 25) {
        //The cost of the pumpkin up to 25 lbs.
        alert(`Your pumpkin of ${pumpkinWeight} lbs. costs \$${(pumpkinWeight * .80).toFixed(2)}`);
    } else if (pumpkinWeight < 50) {
        //The cost of the pumpkin up to 50 lbs.
        alert(`Your pumpkin of ${pumpkinWeight} lbs. costs \$${(pumpkinWeight * .70).toFixed(2)}`);
    } else if (pumpkinWeight <= 100) {
        //The cost of the pumpkin up to and including 100 lbs.
        alert(`Your pumpkin of ${pumpkinWeight} lbs. costs \$${(pumpkinWeight * .60).toFixed(2)}`);
    } else if (pumpkinWeight>100) {
        //The cost of the pumpkin above 100 lbs.
        alert(`Your pumpkin of ${pumpkinWeight} lbs. costs \$${(pumpkinWeight * .50).toFixed(2)}`);
    }
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


alert("Lets move on to the next problem. Press ok to continue:");


//------------------------------Problem #4: Loyalty Card------------------------------//

//Greet user with new problem
alert("Welcome to the Loyalty Card calculator.\r\nLets find the cost of your items\r\n");

//Ask customer for cost of first item
//Create condition to convert and verify user response
let item1Cost = validate(0, "What is the cost of your first item?", "Enter the cost as a positive number.");
if (item1Cost != null) {
    //Ask customer for cost of second item
    //Create condition to convert and verify user response
    let item2Cost = validate(0, "What is the cost of your second item?", "Enter the cost as a positive number.");
    if (item2Cost != null) {
        // Make sure variables are read as numbers
        item1Cost = parseFloat(item1Cost);
        item2Cost = parseFloat(item2Cost);
        //Calculate the total cost of the two items
        let totalCost = item1Cost  + item2Cost;
        //Calculate total cost with discount
        let discount = totalCost * .15;
        let totalCostDiscount = totalCost - discount;

        let loop = true;
            while (loop) {
            //ask the user if they are a preferred customer
            //catch user response for preferred Customer
            let preferredMemberStatus = prompt("Are you a Preferred Member? Enter (yes/no)").toLocaleLowerCase();
            //Creat a condition that determines if the user gets a 15% discount
            switch(preferredMemberStatus) {
                case "y":
                case "yes":
                    loop = false;
                    //Calculate cost of the two items with a 15% discount and inform the user
                    alert(`Your total purchase is \$${totalCostDiscount.toFixed(2)}, which includes your 15% discount.`);
                    break;
                case "n":
                case "no":
                    loop = false;
                    //tell user the total cost without the discount
                    alert(`Your total purchase is \$${totalCost.toFixed(2)}.`);
                    break;
                default:
                    if (preferredMemberStatus == null) {
                        loop = false;
                        break;
                    }
                    break;

            }

        }
    }
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

alert(`End of Program`);