// Functions
function validateMinMax(min,max,stm1,stm2){
    let stmCheck = stm1;
    let value;
    do {
        value = prompt(stm1);
        if (value === null){
            return value;
        }
        if ((value<min || isNaN(value) || value === "") && stm1 === stmCheck)
        {
            stm1 += `\r\n${stm2}`;
        }

    }while(value< min || value>max || isNaN(value) || value ==="");
    return value;
}

function validate(min,stm1,stm2){
    let stmCheck = stm1;
    let value;
    do {
        value = prompt(stm1);
        if (value === null){
            return value;
        }
        if ((value<min || isNaN(value) || value === "") && stm1 === stmCheck)
        {
            stm1 += `\r\n${stm2}`;
        }

    }while(value< min || isNaN(value) || value ==="");
    return value;
}

//--------------------Problem #1 - Logical Operators: Making the Grade--------------------//

//Greet the user
alert("Welcome to Making the Grade!\r\nLets find out if you passed!");

//Create values to store the grades
let grade1;
let grade2;

//Ask user for first grade
//Catch user response for first grade
//Convert string to int and verify user response
grade1 = validateMinMax(0,100,`What is the first grade you received?`, `Enter a number between 0 and 100`);
if (grade1 != null){
    grade1 = parseInt(grade1);

    //Ask user for second grade
    //Catch user response for second grade
    //Convert string to int and verify user response
    grade2 = validateMinMax(0,100,`What is the second grade you received?`, `Enter a number between 0 and 100`);
    if (grade2 != null){
        grade2 = parseInt(grade2);
        //Create array to store the grades
        let grades;
        grades = [grade1,grade2]
        //create a condition that will check each grade in the array and determine if it is passing
        let gradeIsPassing = true;
        for(let i = 0; i < grades.length; i++){
            if(grades[i] < 70){
                gradeIsPassing = false;
            }
        }

        //Tell the user the results
        if (gradeIsPassing == false){
            //If one or more grades is failing
            alert("One or more grades are failing, try harder next time!")
        } else{
            //If both grades are higher than 70
            alert("Congrats, both grades are passing!")
        }

        //Thank the user for using the program
        alert("Thank you for using Making the Grade!\r\nLets move on to the next problem. Hit ok to continue:");

    }else{
        console.log(`Making the Grade. CANCELLED.`)
    }

    /*
     Data Sets to Test:

     Test #1: Grade1 = 95, Grade2 = 85, Results = "Congrats, both grades are passing!"
     Test #2: Grade1 = 82, Grade2 = 68, Results = "One or more grades are failing, try harder next time!"
     Test #3: Grade1 = Eighty (Computer should re-promt user),Grade1 = 80 Grade2 = 91, Results = "Congrats, both grades are passing!"
     Test #4: Grade1 = 69, Grade2 = 70, Results = "One or more grades are failing, try harder next time!"
    */
}else{
    console.log(`Making the Grade. CANCELLED.`)
}


//--------------------Problem #2 - Logical Operators: Brunch Bunch--------------------//

//Welcome the user
alert("Welcome to Brunch Bunch!\r\nLets find out if you're eligible for a discount.");

//ask user their age
//Catch user response for their age
//Create int to hold user response
let age = validateMinMax(1,200,`Please tell me your age.`, `Please enter your age as a integer and greater than 0.`);
if (age != null){
    age = parseInt(age);

    //create decimal to hold prices
    let seniorOrKid = 10.00;
    let noDiscount = 15.00;

    if (age >= 55 || age < 10) {
        //Does not receive discount
        alert(`Your cost for brunch today is \$${seniorOrKid.toFixed(2)}`);
    } else {
        //user may receive discount
        alert(`Your cost for brunch today is \$${noDiscount.toFixed(2)}`);
    }

//Thank the user for using the program
    alert("Thank you for using Brunch Bunch!\r\nLets move on to the next problem. Hit ok to continue:");
}else{
    console.log(`Welcome to Brunch! CANCELLED.`)
}


/*
 Data Sets to Test:

Test #1: Age=57, Results ="Your cost for brunch today is $10.00"
Test #2: Age=39, Results ="Your cost for brunch today is $15.00"
Test #3: Age=8, Results ="Your cost for brunch today is $10.00"
Test #4: Age=10, Results ="Your cost for brunch today is $15.00"
Test #5: Age=Fifty Five (Computer should re-prompt), Age=55, Results ="Your cost for brunch today is $10.00"

 */


//--------------------Problem #3 - For Loop: Add Them Up--------------------//

//Greet the user
alert("Welcome to Add Them Up!\r\nLets find out how many movies you own.");
//Create variables for DVDs,Blue-Rays, and Digital UltraViolet
let dvd;
let blueRay;
let ultraViolet;

//ask user for number of DVD's
//catch user response for DVD's
//convert to int and verify user response
dvd = validate(0,`How many DVD's do you own?`, `Enter a number of 0 or greater.`);
if (dvd != null) {
    dvd = parseInt(dvd);
    //ask user for number of blue-rays
    //catch user response for blue-rays
    //convert to int and verify user response
    blueRay = validate(0,`How many Blu-Rays do you own?`, 'Enter a number of 0 or greater.')
    if (blueRay != null) {
        blueRay = parseInt(blueRay)
        //ask user for number of ultraViolet movies
        //catch user response for ultraViolet movies
        //convert to int and verify user response
        ultraViolet = validate(0,`How many UltraViolet movies do you own?`, `Enter a number of 0 or greater.`)
        if (ultraViolet != null) {
            ultraViolet = parseInt(ultraViolet);

            //create array to hold user input
            let movies = [dvd, blueRay, ultraViolet];
            //Create a variable to hold the sum of the array
            let moviesTotal = 0;

            //Creat for-loop to add up total number of movies
            for (let i = 0; i < movies.length; i++)
            {
                moviesTotal += movies[i];

            }
            if (moviesTotal > 100)
            {
                alert(`Wow, I am impressed with your collection of ${moviesTotal} movies!`);
            }
            else
            {
                alert(`You have a total of ${moviesTotal} movies in your collection.`);
            }


            //Thank the user for using the program
            alert("Thank you for using Add Them Up!\r\nLets move on to the next problem. Hit ok to continue:");

        }else {
            console.log(`Add Them Up! CANCELLED`)
        }

    }else{
        console.log(`Add Them Up! CANCELLED`)
    }

}else{
    console.log(`Add Them Up! CANCELLED`)
}

/*
* Testing:
*
* Test #1: How many DVD's do you own?: 0
*          How many Blu-Rays do you own?: 1
*          How many UltraViolet movies do you own?: 3
*               Result: You have a total of 4 movies in your collection.
*
* Test #2: How many DVD's do you own?: 100
*          How many Blu-Rays do you own?: 50
*          How many UltraViolet movies do you own?: 2
*               Result: Wow, I am impressed with your collection of 152 movies!
* */


//--------------------Problem #4 - While Loop: Cha-Ching!--------------------//

//Greet  user
alert("Welcome to Cha-Ching!\r\nLets see how many items we can buy with your gift card.");

//ask user for gift card amount
//catch user response for gift card amount
//create variable to hold gift card string
let giftCard = validate(0, `How much money do you have on your gift card?`, `Enter the dollar amount of your gift card.`)

if (giftCard != null) {
    //convert string and verify user response
    giftCard = parseFloat(giftCard);

    //creat a while loop to process the user's purchases
    let purchaseLoop = true;
    do
    {
        //ask customer for cost of purchase
        //catch user response
        //create variable to hold string
        let purchase = validate(0,`How much is your purchase?`, `Enter the dollar amount of your purchase.`);
        if (purchase != null) {
            //convert string to decimal and verify response
            purchase = parseFloat(purchase);

            //Have the purchase be subtracted from the gift card
            giftCard -= purchase;

            //create condition for when the gift card reaches zero or a negative balance is due
            if (giftCard > 0)
            {
                //Tell user how much is left of their gift card
                alert(`With your purchase of \$${purchase.toFixed(2)}, you can still spend \$${giftCard.toFixed(2)}`);
            }
            else
            {
                let giftCardBalance = giftCard * -1;
                //Tell user how much they owe after using the gift card
                alert(`\r\nWith your last purchase of \$${purchase.toFixed(2)}, you have used your gift card up and still owe \$${giftCardBalance.toFixed(2)}.`);

                //Thank the user for using the program
                alert("Thank you for running my program.\r\nYou have completed all the problems. Hooray!" +
                    "\r\nEnd of Program.");
            }

        } else {
            purchaseLoop = false;
            console.log('While Loop: Cha-Ching! CANCELLED');
            }

    } while (giftCard > 0 && purchaseLoop);
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

}else {

    console.log('While Loop: Cha-Ching! CANCELLED');
}