//Welcoming message to the user
console.log('Start of Program');
alert("Welcome to GroceryCalc!"+"\r\nPlease follow the instructions below to find out the cost of your grocery list.");
var i = 0;
// create dictionary to hold item and itemCost
var dict = {};
do {
    //Ask user for type of item
    var item = prompt(`Enter the name of the item in your grocery cart.`);

    //Ask user for the cost of first item
    var itemCost = prompt(`Please enter the cost of your ${item}`);
    //Convert the string itemCost to double
    itemCost = parseFloat(itemCost);

    //Ask the user for the total number of items
    var itemQuantity = prompt(`Please enter the total number of ${item}'s you have.`);
    //Convert string itemQuantity to int
    itemQuantity = parseInt(itemQuantity);

    //Find the total cost of the item
    //item1Number*item1Convert
    var itemTotalCost = itemQuantity * itemCost;

    //User receives total cost of first item
    dict[item] = itemTotalCost;
    i++;
    // alert(`Total cost of your ${item} before tax is ${itemTotalCost.toFixed(2)}`);
    
}while(i < 3);
//------------------------------------End of item list------------------------------------------------


//Calculate total costs of the grocery cart with tax
//Ask customer for sales tax
var tax = prompt(`Please enter the tax in your area. (Example: 7.2,4.0,3.5,etc.)`)

//Convert string tax to double
tax = parseFloat(tax);
//Change % to Decimal
tax /= 100;

//User results
//User receives itemized list of items, total cost before tax, sales tax total, total cost with sales tax
let stm = "";
var totalCost = 0;
for (var key in dict) {
    var value = dict[key];
    let stm = `Total cost of the ${key}'s before tax is \$${value.toFixed(2)}.\r\n`;
    //Total cost of items before tax
    totalCost += value;
    console.log(stm);

}
//spacing control
stm +=(`Total cost of all items before tax is \$${totalCost.toFixed(2)}\r\n`);

//Calculate tax of all items
//(totalCost)*taxConvert
var taxTotal = totalCost * tax;
stm +=`Total sales tax on all items is \$${taxTotal.toFixed(2)}\r\n`;

//Calculate total cost including tax
//taxTotal+totalCost
var totalWithTax = taxTotal + totalCost;

//Give user final cost with tax
stm +=`Total of all items including tax is \$${totalWithTax.toFixed(2)}`;
alert(stm);

console.log('End of Program.');
//This program used two test to ensure accuracy using the inputs below
/*
 Inputs for test #1
 - Name of item: Apple - Cost of item: 0.50 - Quantity of item: 4 - Total cost of Apples before tax is $2.00

 - Name of item2: Steak - Cost of item2: 15.25 - Quantity of item2: 2 - Total cost of Steaks before tax is $30.50

 - Name of item3: Ice Cream - Cost of item3: 5.75 - Quantity of item3: 1 - Total cost of Ice Creams before tax is $5.75

 - Sales Tax in My Area: 7

 Results
 - Total cost of all items before tax is $38.25
 - Total sales tax on all items is $2.68
 - Total of all items including sales tax is $40.93

 Inputs of test #2
 - Name of item: Apple
 - Name of item2: Steak
 - Name of item3: Ice Cream

 - Cost of item: 0.75
 - Cost of item2: 13.24
 - Cost of item3: 3.75

 - Quantity of item: 6
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