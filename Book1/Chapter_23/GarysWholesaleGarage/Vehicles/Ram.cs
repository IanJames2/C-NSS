using System;

namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

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


        public void RefuelTank()
        {
            // method definition omitted
        }
    }
}
