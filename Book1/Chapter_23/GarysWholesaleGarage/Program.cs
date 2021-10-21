using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main (string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<Vehicle> electricVehicles = new List<Vehicle> {
                new Zero { BatteryKWh = 2.4, MainColor = "Blue", MaximumOccupancy = 4, CurrentChargePercentage = 94.0},
                new Zero { BatteryKWh = 2.4, MainColor = "Silver", MaximumOccupancy = 4, CurrentChargePercentage = 74.0},
                new Tesla {BatteryKWh = 3.6, MainColor = "Red", MaximumOccupancy = 5, CurrentChargePercentage = 68.0},
            };

            Console.WriteLine("Electric Vehicles");
            foreach(Vehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach(Vehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            // foreach(??? ev in electricVehicles)
            // {
            //     Console.WriteLine($"{ev.CurrentChargePercentage}");
            // }

            // /***********************************************/

            // Ram ram = new Ram ();
            // Cessna cessna150 = new Cessna ();

            // List<???> gasVehicles = new List<???>() {
            //     ram, cessna150
            // };

            // Console.WriteLine("Gas Vehicles");
            // foreach(??? gv in gasVehicles)
            // {
            //     Console.WriteLine($"{gv.CurrentTankPercentage}");
            // }

            // foreach(??? gv in gasVehicles)
            // {
            //     // This should completely refuel the gas tank
            //     gv.RefuelTank();
            // }

            // foreach(??? gv in gasVehicles)
            // {
            //     Console.WriteLine($"{gv.CurrentTankPercentage}");
            // }
        }
    }
}
