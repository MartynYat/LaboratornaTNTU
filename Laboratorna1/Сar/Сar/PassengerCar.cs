using System;

namespace CarLibrary
{
    public class PassengerCar : Car
    {
        public int PassengerCapacity { get; set; }

        public PassengerCar(string brand, string color, double engineVolume, int passengerCapacity)
            : base(brand, "Passenger", color, engineVolume)
        {
            PassengerCapacity = passengerCapacity;
        }
    }
}
