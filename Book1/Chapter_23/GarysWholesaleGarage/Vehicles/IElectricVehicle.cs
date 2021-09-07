using System;

namespace Garage 
{
    public interface IElectricVehicle
    {
        double BatteryKWh { get; set; }
        
        void ChargeBattery(string vehicleModelName);
    }
}