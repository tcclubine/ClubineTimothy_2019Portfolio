class Cars {
    constructor(year, make, model, color){

        do {
            if (year > 0) {
                this._year = year;
                this._make = make;
                this._model = model;
                this._color = color
            }else
            {
                alert('Year is invalid.');
                year = prompt('Enter the year of the vehicle.');
            }

        }while(year <= 0)




    };
};

class SportCar extends Cars(){
    constructor(year, make, model, color, engineSize, transmission){
        super(year, make, model, color);
        this._engineSize = engineSize;
        this._transmission = transmission;
    };

    Specs(){
        console.log(year + make + model);
    };

};

car = new SportCar(1990,'Nissan','300zx','Red',3.0, '5-speed manual');

car.Specs();