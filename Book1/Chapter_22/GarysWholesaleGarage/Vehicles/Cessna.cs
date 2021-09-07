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

        public override void Drive()
        {
            Console.WriteLine("Sccccccccrh! Blue");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"Cessna's turning {direction} now");
        }
        public override void Stop()
        {
            Console.WriteLine("Cessna mx410 Stopping Now!");
        }
    }
}
