using System;
using System.Collections.Generic;
using System.Text;

namespace _05_AbstractClassPolymorphismForEach
{
    public class Truck : Vehicle
    {
        public double CargoCapacity { get; set; }
        public int AxleCount { get; set; }
        public double CurrentLoad { get; set; }
        public override int MaxSpeed { get;set; }

        public Truck(string brand,string model,int year,string plateNumber,double cargoCapacity, int axleCount, double currentLoad, int maxSpeed):base(brand,model,year,plateNumber,100)
        {
            CargoCapacity = cargoCapacity;
            AxleCount = axleCount;
            CurrentLoad = currentLoad;
            MaxSpeed = maxSpeed;
        }
      public void ShowTruckInfo()
        {
            Console.WriteLine($"[Truck] {GetVehicleInfo()},Axles: {AxleCount},Load: {CurrentLoad} / {CargoCapacity}" );
        }
        public void LoadCargo(double weight)
        {
            if (CurrentLoad + weight <= CargoCapacity)
                CurrentLoad += weight;
            else
                Console.WriteLine("Error: Capacity exceeded" );
        }
        public override double CalculateFuelCost(double distance)
        {
            return (distance / 100) * (25 + CurrentLoad * 2) * 1.80;
        }
    }
}
