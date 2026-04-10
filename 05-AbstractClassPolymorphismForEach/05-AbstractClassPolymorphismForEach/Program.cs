using _05_AbstractClassPolymorphismForEach;

class Program
{
    static void Main()
    {
        Car car1 = new Car("Mercedes", "E200", 2023, "10-AA-001", 4, 500, true, 220);
        Car car2 = new Car("BMW","320i",2022,"99-BB-999",4,480,true,235);
        Car car3 = new Car("Toyota", "Camry", 2021, "77-CC-777", 4, 524, true, 210);


        Motorcycle moto1 = new Motorcycle("Yamaha", "R1", 2023, "10-M-001", 998, "Sport", false, 299);
        Motorcycle moto2 = new Motorcycle("Harley-Davidson","Softail",2022,"10-M-002",1868,"Cruiser",true,180);

        Truck truck1 = new Truck("MAN","TGX",2020,"90-TT-100",18,3,12,120);
        Truck truck2 = new Truck("Volvo", "FH16", 2021, "90-TT-200", 25, 4, 18, 110);


        List<Vehicle> vehicles = new List<Vehicle>() {car1,car2,car3,moto1,moto2,truck1,truck2};

        car1.ShowCarInfo();
        Console.WriteLine($"Cost (500 km): {car1.CalculateFuelCost(500)} AZN" );
        car2.ShowCarInfo();
        Console.WriteLine($"Cost (500 km): {car2.CalculateFuelCost(500)} AZN");
        car3.ShowCarInfo();
        Console.WriteLine($"Cost (500 km): {car3.CalculateFuelCost(500)} AZN");

        moto1.ShowBasicInfo();
        Console.WriteLine($"Cost (300 km): {moto1.CalculateFuelCost(300)} AZN");
        moto2.ShowBasicInfo();
        Console.WriteLine($"Cost (300 km): {moto2.CalculateFuelCost(300)} AZN");

        truck1.ShowTruckInfo();
        Console.WriteLine($"Cost(800 km): {truck1.CalculateFuelCost(800)} AZN");
        truck2.ShowTruckInfo();
        Console.WriteLine($"Cost(800 km): {truck2.CalculateFuelCost(800)} AZN");

        truck1.LoadCargo(5);
        Console.WriteLine($"Yeni yanacaq xerci (800 km) : {truck1.CalculateFuelCost(800)} AZN");

        Console.WriteLine("Umumi Statistika" );
        Console.WriteLine($"Cemi neqliyyat sayi: {vehicles.Count}");

        double avgMaxSpeed = vehicles.Average(vehicle => vehicle.MaxSpeed);
        Console.WriteLine($"Orta maksimum suret: {avgMaxSpeed:F2}  km /saat");

        var expensive = vehicles.OrderByDescending(v => v is Truck ? v.CalculateFuelCost(800) : (v is Car ? v.CalculateFuelCost(500) : v.CalculateFuelCost(300))).First();
        Console.WriteLine($"En bahali yanacaq xerci olan : {expensive.Brand} {expensive.Model}");
    }
}
