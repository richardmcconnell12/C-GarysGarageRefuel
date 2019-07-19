using System;

namespace GarysGarage
{
    public class Tesla : IElectricPowered
    {
        public double BatteryKWh { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public void Refuel()
        {
            Console.WriteLine("Charging Tesla Battery.");
        }
    }
}