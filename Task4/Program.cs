using Task4;

Car car1 = new Car("Toyota", "Corrola", 2011);
car1.AddFuel(110);
car1.Drive(100);
System.Console.WriteLine(car1.Fuel);
car1.Drive(20);
