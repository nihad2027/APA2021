using System;
using System.Collections.Generic;
using System.Text;

namespace _06_InterfaceAbstraction;

public class Calculation : ICalculation
{
    public double Calculate(double num1, double num2, char operation)
    {
        switch (operation)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                if (num2 != 0)
                    return num1 / num2;
                else
                {
                    Console.WriteLine("Sifra bolmek olmur!");
                    return 0;
                }
                default:
                return 0;
        }
    }
}

