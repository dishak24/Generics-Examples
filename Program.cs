using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics Practice !");
            Console.WriteLine();

            CalculatorGenerics.MenuDrivenCalculator(26, 13);
            CalculatorGenerics.MenuDrivenCalculator(26.56, 13.2);

        }

    }

}

