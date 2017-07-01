class Car {
  constructor(year, make, model) {
    this.year = year;
    this.make = make;
    this.model = model;
  }
  printCarInfo() {
    console.log(`The car is a ${this.year} ${this.make} ${this.model}`);
  }
}

class Sedan extends Car {
  constructor(year, make, model, color) {
    super(year, make, model);
    this.color = color;
  }
  static getYellowSedan(year, make, model) {
    return new Sedan(year, make, model, 'Yellow');
  }
}

const myCar = new Sedan(2016, 'BMW', '328i', 'Grey');
myCar.printCarInfo();

const yourCar = Sedan.getYellowSedan(1987, 'Dodge', 'Dart');
yourCar.printCarInfo();
