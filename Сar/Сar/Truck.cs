using System;

namespace CarLibrary
{
    public class Truck : Car
    {
        public double LoadCapacity { get; set; }

        public Truck(string brand, string color, double engineVolume, double loadCapacity)
            : base(brand, "Truck", color, engineVolume)
        {
            LoadCapacity = loadCapacity;
        }
    }
}
