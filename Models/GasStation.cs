using System;
using System.Collections.Generic;

namespace GarysGarage
{
    public class GasStation : IStation<IGasPowered>
    {
        public int Capacity { get; set; }
        public void Refuel(List<IGasPowered> vehicles)
        {
            // Console.WriteLine($"Going to refuel {vehicles}");
        }
    }
}