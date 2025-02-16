using System;
using CarLibrary;

class Program
{
    static void Main()
    {
        // Створення легкового автомобіля
        PassengerCar myPassengerCar = new PassengerCar("Honda", "White", 2.0, 5);
        Console.WriteLine($"Passenger Car: {myPassengerCar.Brand}, Color: {myPassengerCar.Color}, " +
                          $"Engine: {myPassengerCar.EngineVolume}L, Capacity: {myPassengerCar.PassengerCapacity} passengers");
        myPassengerCar.ChangeSpeed(60);
        Console.WriteLine($"Current Speed: {myPassengerCar.Speed} km/h");

        // Створення вантажного автомобіля
        Truck myTruck = new Truck("Volvo", "Blue", 5.0, 20000);
        Console.WriteLine($"\nTruck: {myTruck.Brand}, Color: {myTruck.Color}, " +
                          $"Engine: {myTruck.EngineVolume}L, Load Capacity: {myTruck.LoadCapacity} kg");
        myTruck.ChangeSpeed(30);
        Console.WriteLine($"Current Speed: {myTruck.Speed} km/h");

        // Створення звичайного автомобіля
        Car myCar = new Car("Toyota", "Sedan", "Red", 1.8);
        Console.WriteLine($"\nCar: {myCar.Brand}, Type: {myCar.Type}, Color: {myCar.Color}, Engine: {myCar.EngineVolume}L");
        myCar.ChangeSpeed(50);
        Console.WriteLine($"Current Speed: {myCar.Speed} km/h");

        // Перевірка зменшення швидкості
        myCar.ChangeSpeed(-30);
        Console.WriteLine($"After slowing down, Speed: {myCar.Speed} km/h");
    }
}
