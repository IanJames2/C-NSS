using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public double CurrentChargePercentage { get; set; }

        public virtual void Drive(string vehicleModelName)
        {
            Console.WriteLine("{vehicleModelName} Driving!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"Turn {direction}");
        }

        public virtual void Stop(string vehicleModelName)
        {
            Console.WriteLine("{vehicleModelName} stops now.");
        }
    }
}
