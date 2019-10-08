//-------------------Functions/Methods--------------------//

//Function/Method for problem #1
function EurosConversion(e) {
    //convert Euros to Dollar
    var dollar;
    dollar = e * 1.11; // current rate as of 8/15/2019
    return dollar;
}

//Function/Method for problem #2
function WeightComparison(userWeight, planetChoice) {
    //calc weight of user on each planet
    var weightConversion;
    weightConversion= userWeight * planetChoice;
    return weightConversion;
}

//Function/Method for problem #3
//Create a function that will subtract the matching array elements from each other and store the values in an array
function ArraySubtraction(firstArray, secondArray)
{
    //create a blank array of the same length as the incoming arrays
    var blankArray = [];

    //sort through arrays
    for (var i = 0; i < firstArray.length; i++)
    {
        var temp = firstArray[i] - secondArray[i];
        blankArray.push(temp);

    }

    return blankArray;

}
function displayArrays(firstArray,secondArray) {
    //create a new array to catch results

    var newArray = ArraySubtraction(firstArray, secondArray);
    var stm = "";
//output to console
    for (var i = 0; i < newArray.length; i++)
    {
        stm +=`${firstArray[i]}-${secondArray[i]} is ${newArray[i]}.\r\n`;
    }
    alert(stm);
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


//-------------------Problem #1: Currency Converter--------------------//

//Greet user
alert("Welcome to Currency Converter!" +
    "\r\nToday we are going to help you convert your Euros into American Dollars.");

//ask user for amount to be converted
//catch user response
//create decimal var to hold string
var euros = validate(0,`What is the amount in Euros you would like to convert?`, `Please enter a dollar amount.`);
if (euros != null) {
    //Convert and verify user response
    euros = parseFloat(euros)

    //Function call to convert Euros
    var conversion = EurosConversion(euros);

    //Tell the user the converted value in dollars
    alert(`${euros.toFixed(2)} euros converted to dollars is \$${conversion.toFixed(2)}.`);

    alert("Lets move on to the next problem. Press ok to continue.");

}


/*
 Data Sets to Test:

 Test #1: Euros = 5.50
            -Results = "5.50 euros converted to dollars is $6.11."

 Test #2: Euros = 15.32
            -Results = "$15.32 euros converted to dollars is $17.01."

 Test #2: Euros = 300.29
            -Results = "300.29 euros converted to dollars is $333.32."

 */

//-------------------Problem #2: Astronomical--------------------//

//Greet User
alert("Welcome to Astronomical" +
    "\r\n\r\nYou are an Astronaut floating through space and decided to contemplate what your weight would be on other planets." +
    "\r\nLet me help you out.");

//Ask user for their weight
//Catch user response
//set variable for userWeight
var userWeight = validate(1,`What is your current weight on Earth?`,`Enter a weight greater than 0`);
if (userWeight != null) {
    //Convert string to double and verify user response
    userWeight = parseFloat(userWeight);
    //Ask the user to choose from a list of planets
    //Catch user response for planet picked
    //Hold variable for planet
    var planet = validateMinMax(1,8,
        `Please choose a number from the list of planets below:
        1-Mercury
        2-Venus
        3-Earth
        4-Mars
        5-Jupiter
        6-Saturn
        7-Uranus
        8-Neptune`,
        `Enter a number 1-8.`);

    if (planet != null) {
        //Convert and verify user response
        planet = parseInt(planet);
        //array to hold the planet names
        var planetNamesArray = ["Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"];

        //Create condition to output conversion of selected planet
        var stm = `On Earth you weigh ${userWeight} lbs, `;
        if (planet === 1)
        {
            var planet1 = .38;
            var mercury = WeightComparison(userWeight, planet1);
            stm +=`but on ${planetNamesArray[0]} you would weigh ${mercury} lbs.`;
        }
        else if (planet === 2)
        {
            var planet2 = .91;
            var venus = WeightComparison(userWeight, planet2);
            stm +=`but on ${planetNamesArray[1]} you would weigh ${venus} lbs.`;
        }
        else if (planet === 3)
        {
            var planet3 = 1;
            var earth = WeightComparison(userWeight, planet3);
            stm +=`but on ${planetNamesArray[2]} you would weigh ${earth} lbs.`;
        }
        else if (planet === 4)
        {
            var planet4 = .38;
            var mars = WeightComparison(userWeight, planet4);
            stm +=`but on ${planetNamesArray[3]} you would weigh ${mars} lbs.`;
        }
        else if (planet === 5)
        {
            var planet5 = 2.34;
            var jupiter = WeightComparison(userWeight, planet5);
            stm +=`but on ${planetNamesArray[4]} you would weigh ${jupiter} lbs.`;
        }
        else if (planet === 6)
        {
            var planet6 = .93;
            var saturn = WeightComparison(userWeight, planet6);
            stm +=`but on ${planetNamesArray[5]} you would weigh ${saturn} lbs.`;
        }
        else if (planet === 7)
        {
            var planet7 = .92;
            var uranus = WeightComparison(userWeight, planet7);
            stm += `but on ${planetNamesArray[6]} you would weigh ${uranus} lbs.`;
        }
        else
        {
            var planet8 = 1.12;
            var neptune = WeightComparison(userWeight, planet8);
            stm += `but on ${planetNamesArray[7]} you would weigh ${neptune} lbs.`;
        }
        alert(stm);
        alert("Lets move on to the next problem. Press ok to continue.");
    }


}

/*
 Data Sets to Test:

 Test #1: Astronaut's Weight= 160, Planet Choice= 6
            -Result = "On Earth you weigh 160 lbs, but on Saturn you would weigh 148.8 lbs."

 Test #1: Astronaut's Weight= 210, Planet Choice= 9(Re-prompt because not a valid choice), New Choice= 5
            -Result = "On Earth you weigh 210 lbs, but on Jupiter you would weigh 491.4 lbs."

 Test #3: Astronaut's Weight= 231, Planet Choice= 3
            -Result = "On Earth you weigh 231 lbs, but on Earth you would weigh 231 lbs."
 */

//-------------------Problem #3: Subtraction--------------------//

//Welcome user
alert("Welcome to Subtraction!\r\n" +
    "\r\nThree sets of test data will display for this problem.");
//Declare and define two arrays of at least 5 integer elements
//Comment out Test #2 and Test #3 when testing #1 and vice versa
//Data Sets to Test:

//Test #1
var firstArray = [4, 65, 32, 42, 12];
var secondArray = [1, 2, 5, 6, 9];
displayArrays(firstArray,secondArray)
/*Results of test #1:
    4 - 1 is 3
    65 - 2 is 63
    32 - 5 is 27
    42 - 6 is 36
    12 - 9 is 3
 */

////Test #2
////Comment out Test #1 and #3
firstArray = [54, 125, 96, 72, 45, 67];
secondArray = [87, 122, 145, 65, 3, 800];
displayArrays(firstArray,secondArray);
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
firstArray = [28, 2, 22, 14, 7, 30];
secondArray =[2, 4, 4, 9, 10, 12];
displayArrays(firstArray,secondArray);
/*Results of test #3:
    28 - 2 is 26
    2 - 4 is -2
    22 - 4 is 18
    14 - 9 is 5
    7 - 10 is -3
    30 - 12 is 18
 */

alert("Thank you for using my program. You have completed all the problems. Hooray!");
