//Create Welcome message
alert("Welcome to Mad Libs! Lets have some fun!");

//Create inputs for the user to be used in the MadLib
var animal = prompt(`Name a type of animal.`);

var name = prompt(`Give a Name.`);

var adjective = prompt(`Give an adjective.`);

var foodItem = prompt(`Name a food item.`);

//The year, cost and randomNumber must be converted from a string datatype to a number datatype to meet the assignment goals.
var year = prompt(`Give a Year.`);
year = parseInt(year);

var cost = prompt(`Give a cost in money.`);
cost = parseFloat(cost);

var randomNumber = prompt(`Give a random whole number.`);
randomNumber = parseInt(randomNumber);

//create an array for the number variables using the inputs from above
var madLibs = [year, cost, randomNumber];

//Create a story using the madLibs array.
alert(`A ${animal} named ${name} was ${adjective} when a mysterious traveller approached to sell a ${foodItem}.
The traveller said, \"It will give you blissful dreams while you sleep.\" 
All the traveller asked for in exchange was \$${madLibs[1]}.
${name} agreed and immediately ate the ${foodItem}. It put ${name} to sleep for ${madLibs[2]} years.
When ${name} awoke, the year was ${madLibs[0]} and the traveller stood over him with a sly smile. \"Did you enjoy your nap?\"`);
