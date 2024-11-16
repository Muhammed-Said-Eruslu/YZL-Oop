using _02_OOP_Constructor;

Car car = new Car("Ford");
car.Model = "Focus";
car.Engine = 1500;


Car car1 = new Car("BMW","24");

car1.Engine = 2000;


Car car2 = new Car("Dodge","Challenger",3500);



Console.WriteLine($"{car.Brand} {car.Model} {car.Engine}");
Console.WriteLine($"{car1.Brand} {car1.Model} {car1.Engine}");
Console.WriteLine($"{car2.Brand} {car2.Model} {car2.Engine}");
