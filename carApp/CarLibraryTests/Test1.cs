using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarLibrary;

namespace CarLibraryTests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void TestCarSpeedChange()
        {
            // Створення екземпляру автомобіля
            var myCar = new Car("Toyota", "Sedan", "Red", 1.8);

            // Перевірка початкової швидкості (має бути 0)
            Assert.AreEqual(0, myCar.Speed);

            // Зміна швидкості на 50
            myCar.ChangeSpeed(50);

            // Перевірка, чи змінилася швидкість на 50
            Assert.AreEqual(50, myCar.Speed);

            // Зміна швидкості на -30
            myCar.ChangeSpeed(-30);

            // Перевірка, чи стала швидкість 20 (не може бути менше за 0)
            Assert.AreEqual(20, myCar.Speed);
        }

        [TestMethod]
        public void TestPassengerCarSpeedChange()
        {
            // Створення екземпляру легкового автомобіля
            var myPassengerCar = new PassengerCar("Honda", "White", 2.0, 5);

            // Перевірка початкової швидкості (має бути 0)
            Assert.AreEqual(0, myPassengerCar.Speed);

            // Зміна швидкості на 60
            myPassengerCar.ChangeSpeed(60);

            // Перевірка, чи змінилася швидкість на 60
            Assert.AreEqual(60, myPassengerCar.Speed);
        }

        [TestMethod]
        public void TestTruckSpeedChange()
        {
            // Створення екземпляру вантажного автомобіля
            var myTruck = new Truck("Volvo", "Blue", 5.0, 20000);

            // Перевірка початкової швидкості (має бути 0)
            Assert.AreEqual(0, myTruck.Speed);

            // Зміна швидкості на 30
            myTruck.ChangeSpeed(30);

            // Перевірка, чи змінилася швидкість на 30
            Assert.AreEqual(30, myTruck.Speed);
        }

        [TestMethod]
        public void TestCarSpeedDoesNotGoNegative()
        {
            // Створення екземпляру автомобіля
            var myCar = new Car("Honda", "Coupe", "Black", 2.5);

            // Зміна швидкості на -50 (не можна мати негативну швидкість)
            myCar.ChangeSpeed(-50);

            // Перевірка, чи швидкість дорівнює 0
            Assert.AreEqual(0, myCar.Speed);
        }
    }
}
