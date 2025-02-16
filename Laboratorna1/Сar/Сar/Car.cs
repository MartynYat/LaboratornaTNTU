using System;

namespace CarLibrary
{
    public class Car
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public double EngineVolume { get; set; }
        public int Speed { get; private set; }

        public Car(string brand, string type, string color, double engineVolume)
        {
            Brand = brand;
            Type = type;
            Color = color;
            EngineVolume = engineVolume;
            Speed = 0;
        }

        public void ChangeSpeed(int delta)
        {
            Speed += delta;
            if (Speed < 0) Speed = 0;
        }
    }
}
