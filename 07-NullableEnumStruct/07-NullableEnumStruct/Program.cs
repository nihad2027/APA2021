using _07_NullableEnumStruct;

class Program
{
    static void Main(string[] args)
    {
        DrinkOrder order1 = new DrinkOrder(101, "Ali", DrinkType.Coffee, DrinkSize.Medium);
        order1.DisplayOrder();
        order1.UpdateStatus(OrderStatus.Preparing);
        order1.UpdateStatus(OrderStatus.Ready);
        order1.UpdateStatus(OrderStatus.Delivered);

        DrinkOrder order2 = new DrinkOrder(102, "Leyla", DrinkType.Tea, DrinkSize.Large);
        order2.DisplayOrder();
        order2.UpdateStatus(OrderStatus.Ready);
        order2.DisplayOrder();

        DrinkOrder order3 = new DrinkOrder(103, "Vuqar", DrinkType.Juice, DrinkSize.Small);
        order3.DisplayOrder();

        Console.WriteLine("Butun DrinkType deyerleri:");
        foreach (var val in Enum.GetValues(typeof(DrinkType)))
            Console.WriteLine("-" + val);
        Console.WriteLine("Butun DrinkSize deyerleri:");
        foreach (var val in Enum.GetValues(typeof(DrinkSize)))
            Console.WriteLine("-" + val);

        Console.WriteLine($"ToString : {DrinkType.Coffee.ToString()}");

        DrinkType parsedDrink = (DrinkType)Enum.Parse(typeof(DrinkType), "Tea");
        DrinkSize parsedSize = (DrinkSize)Enum.Parse(typeof(DrinkSize), "Medium");
        Console.WriteLine($"Parse : {parsedDrink} , {parsedSize}");

        Console.WriteLine("Statistika");
        Console.WriteLine($"Umumi sifaris sayi : 3");
        Console.WriteLine($"Sifaris1 Qiymet :{order1.Price} AZN");
        Console.WriteLine($"Sifaris2 Qiymet :{order2.Price} AZN");
        Console.WriteLine($"Sifaris3 Qiymet :{order3.Price} AZN");

        decimal totalAmount = order1.Price + order2.Price + order3.Price;
        Console.WriteLine($"Umumi mebleg : {totalAmount} AZN");
    }
}
