using System;
using System.Collections.Generic;
using System.Text;

namespace _05_AbstractClassPolymorphismForEach
{
    public class Car : Vehicle
    {
        public int DoorsCount { get; set; }
        public int TrunkCapacity { get; set; }
        public bool IsAutomatic { get; set; }
        public override int MaxSpeed { get; set; }
        public Car(string brand, string model, int year, string plateNumber, int doors, int trunk, bool IsAuto, int maxSpeed) : base(brand, model, year, plateNumber,100)
        {
            this.DoorsCount = DoorsCount;
            this.TrunkCapacity = TrunkCapacity;
            this.IsAutomatic = IsAutomatic;
            this.MaxSpeed = maxSpeed;
        }
        public void ShowCarInfo()
        {
            Console.WriteLine($"[Car] GetVehicleInfo(),Doors:{DoorsCount},Trunk:{TrunkCapacity},Auto:{IsAutomatic}" );
        }
        public override double CalculateFuelCost(double distance)
        {
            return (distance / 100) * 8 * 1.50;
        }
    }
}
