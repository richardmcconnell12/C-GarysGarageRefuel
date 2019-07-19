using System;

namespace GarysGarage
{
    public class Ford : IGasPowered
    {
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public void Refuel()
        {
            Console.WriteLine("Adding fuel to the Mustang.");
        }
    }
}