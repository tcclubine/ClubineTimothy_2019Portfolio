// Create a parent class (you choose! animals, birds, cars, etc)
class Vehicle {
    // Add a Constructor to parent class
    constructor(year, make, model, color, engineSize, transmission, numOfDoors, seatingCapacity){

        do {
            if (year > 0) {
                //Add at least one property
                this._year = year;
                this._make = make;
                this._model = model;
                this._color = color;
                this._engineSize = engineSize;
                this._transmission = transmission;
                this._numOfDoors = numOfDoors;
                this._seatingCapacity = seatingCapacity;
                break;

            }else
            {
                alert('Year is invalid.');
                year = prompt('Enter the year of the vehicle.');
            }

        }while(year < 0 || this._make == null)
    };

    // Add at least one method to the parent class
    toString(){
        return '('+ this._year + ', ' + this._make + ', ' + this._model + ', ' + this._color + ', ' + this._engineSize + ', ' + this._transmission + ', ' + this._numOfDoors + ',' + this._seatingCapacity + ')';
    }
};

// Create at least one class extended (child class) from the parent class
class SportCar extends Vehicle {
    constructor(year, make, model, color, engineSize, transmission, numOfDoors, seatingCapacity, description){
        super(year, make, model, color, engineSize, transmission, numOfDoors, seatingCapacity);
        // Add at least one property and one method to the new extended class/child class
        this._description = description;
    };
    toString(){
        return super.toString()+ ' ' + this._description;
    };
};

// Instantiate at least one object from the parent class (super class)
let myCar = new Vehicle(-1, 'superMake','superModel','superColor','superEngineSize','superTransmission','superDoors','superCapacity');

//Run/Call a method (function) from your parent class (super class)
console.log(myCar.toString());

// Instantiate at least one object from the child class
myCar = new SportCar(1990,'Nissan','300zx','Red','3.0L', '5-speed manual', '2 door', 'capacity 4', 'This is a sports car!');

console.log(myCar.toString());

