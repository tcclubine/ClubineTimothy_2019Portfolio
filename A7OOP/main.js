class Vehicle {
    constructor(year, make, model, color, engineSize, transmission, numOfDoors, seatingCapacity){

        do {
            if (year > 0) {
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

    toString(){
        return '('+ this._year + ', ' + this._make + ', ' + this._model + ', ' + this._color + ', ' + this._engineSize + ', ' + this._transmission + ', ' + this._numOfDoors + ',' + this._seatingCapacity + ')';
    }
};

class SportCar extends Vehicle{
    constructor(year, make, model, color, engineSize, transmission, numOfDoors, seatingCapacity){
        super(year, make, model, color, engineSize, transmission, numOfDoors, seatingCapacity);
    };
};

let myCar = new Vehicle(-1, 'superMake','superModel','superColor','superEngineSize','superTransmission','superDoors','superCapacity');
console.log(myCar.toString());

myCar = new SportCar(1990,'Nissan','300zx','Red','3.0L', '5-speed manual', '2 door', 'capacity 4');

console.log(myCar.toString());

