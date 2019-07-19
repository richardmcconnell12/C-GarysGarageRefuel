using System;
using System.Collections.Generic;

namespace GarysGarage
{
    public class BatteryStation : IStation<IElectricPowered>
    {
        public int Capacity { get; set; }
        public void Refuel(List<IElectricPowered> vehicles)
        {
            // Console.WriteLine($"Going to refuel {vehicles}");
        }
    }
}