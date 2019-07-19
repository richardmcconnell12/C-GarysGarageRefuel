using System;
using System.Collections.Generic;

namespace GarysGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Tesla Tesla = new Tesla();
            Zero Zero = new Zero();

            List<IElectricPowered> BatteryVehicles = new List<IElectricPowered>()
            {
                Tesla, Zero
            };

            BatteryVehicles.ForEach(b => b.Refuel());

            BatteryStation PowerTower = new BatteryStation();
            PowerTower.Refuel(BatteryVehicles);

            Kia KiaSoul = new Kia();

            List<IGasPowered> GasVehicles = new List<IGasPowered>()
            {
                KiaSoul
            };

            GasVehicles.ForEach(g => g.Refuel());

            GasStation Citgo = new GasStation();
            Citgo.Refuel(GasVehicles);

        }
    }
}
