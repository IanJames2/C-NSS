using System;


namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

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
