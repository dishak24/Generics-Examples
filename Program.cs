using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics Practice !");
            Console.WriteLine();

            SwapNumbers.Swap("Disha", "Nisha");
            SwapNumbers.Swap(97.68, 67.90);
            SwapNumbers.Swap('D', 'B'); 

            CompareDifferentDataType.CompareType(12, 55);
            CompareDifferentDataType.CompareType(12, 12);
            CompareDifferentDataType.CompareType(0.009, 3.004);
            CompareDifferentDataType.CompareType("Disha", "Disha");
            CompareDifferentDataType.CompareType(66, 33);




            MinMax.FindMax(10, 12, 9);
            MinMax.FindMax(7.9, 9.0, 2.5);
            MinMax.FindMin(7.9, 9.0, 2.5);
            MinMax.FindMax('A', 'B', 'c');

            CalculatorGenerics.MenuDrivenCalculator(26,13);
            CalculatorGenerics.MenuDrivenCalculator(26.56, 13.2);


            SwapNumbers.Swap(10,20);
            SwapNumbers.Swap("Disha", "Nisha");
            SwapNumbers.Swap(97.68, 67.90);
            SwapNumbers.Swap('D', 'B');

            CompareDifferentDataType.CompareType(12, "adfhjm");
            CompareDifferentDataType.CompareType(12, "12");
            CompareDifferentDataType.CompareType(12, 34);
            CompareDifferentDataType.CompareType("Disha", "Disha");
            CompareDifferentDataType.CompareType(66, 33);


        }

    }

}

