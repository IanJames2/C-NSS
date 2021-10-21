using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public override void Drive(string vehicleModelName)
        {
            Console.WriteLine("{vehicleModelName} Driving!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"Turn {direction}");
        }

        public override void Stop(string vehicleModelName)
        {
            Console.WriteLine("{vehicleModelName} stops now.");
        }

        public void ChargeBattery(string vehicleModelName)
        {
            Console.WriteLine($"{vehicleModelName} charging now!");
        }
    }
}
