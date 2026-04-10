using _06_InterfaceAbstraction;

class Program
{
    static void Main(string[] args)
    {
        Calculation calc = new Calculation();
        Console.WriteLine("Kalkulyator");

        Console.Write("Birinci reqemi daxil edin : ");
        double num1= Convert.ToDouble(Console.ReadLine());

        Console.Write("Emeliyyati daxil edin (+,-,*,/):");
        char oper = Convert.ToChar(Console.ReadLine());

        Console.Write("Ikinci reqemi daxil edin :");
        double num2= Convert.ToDouble(Console.ReadLine());

        double result = calc.Calculate(num1, num2, oper);
        Console.WriteLine($"Netice:{result}");
    }
}