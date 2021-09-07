using System;

namespace Garage
{
    public class Zero : Vehicle// Electric motorcycle
    {
        public double BatteryKWh { get; set; }

                public override void Drive()
        {
            Console.WriteLine("I don't know what a zero is. Green");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"Zero's turning {direction} now");
        }

        public override void Stop()
        {
            Console.WriteLine("Zero fxs Stopping Now!");
        }



        public void ChargeBattery()
        {
            // method definition omitted
        }
    }
}
