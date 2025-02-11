using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics Practice !");
            Console.WriteLine();

            MinMax.FindMax(10, 12, 9);
            MinMax.FindMin(10, 12, 9);
            MinMax.FindMax(7.9, 9.0, 2.5);
            MinMax.FindMin(7.9, 9.0, 2.5);
            MinMax.FindMax('A', 'B', 'c');
            MinMax.FindMin('A', 'B', 'c');
        }

    }

}

