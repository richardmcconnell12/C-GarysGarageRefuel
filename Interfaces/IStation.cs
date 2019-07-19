using System.Collections.Generic;

namespace GarysGarage
{
    public interface IStation<TStation>
    {
        int Capacity { get; set; }
        void Refuel(List<TStation> vehicles);
    }
}