using System;

namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public override void Drive()
        {
            Console.WriteLine("The Ram Truck looks nice! Yellow");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"Ram's turning {direction} now");
        }

        public override void Stop()
        {
            Console.WriteLine("Ram ram1500 Stopping Now!");
        }


        public void RefuelTank()
        {
            // method definition omitted
        }
    }
}
