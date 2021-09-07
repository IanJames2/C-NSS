using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            Console.WriteLine("I want a Tesla. Hope it comes soon. Silver");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"Tesla's turning {direction} now");
        }

        public override void Stop()
        {
            Console.WriteLine("Tesla modelS Stopping Now!");
        }


        public void ChargeBattery()
        {
            // method definition omitted
        }
    }
}

