using System;
using System.Collections.Generic;
using System.Text;

namespace _05_AbstractClassPolymorphismForEach
{
    public class Motorcycle : Vehicle
    {
        public int EngineCapacity { get; set; }
        public bool HasSidecar { get; set; }
        public string Type { get; set; }
        public override int MaxSpeed { get; set; }

        public Motorcycle(string brand,string model, int year, string plateNumber, int engine,string type,bool sidecar,int maxSpeed) : base(brand,model,year,plateNumber,100)
        {
            EngineCapacity = engine;
            Type = type;
            HasSidecar = sidecar;
            MaxSpeed = maxSpeed;
        }
        public void ShowMotorcycleInfo()
        {
            Console.WriteLine($"[Moto] {GetVehicleInfo()}, Type: {Type}, Engine: {EngineCapacity},Sidecar:{HasSidecar}" );
        }
        public override double CalculateFuelCost(double distance)
        {
            return (distance / 100) * 4 * 1.50;
        }
    }
}
