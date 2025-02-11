using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics Practice !");
            Console.WriteLine();

            CompareDifferentDataType.CompareType(12,67);
            CompareDifferentDataType.CompareType(100, 34);
            CompareDifferentDataType.CompareType("Disha", "Disha");
            CompareDifferentDataType.CompareType(6.7, 3.9);

        }

    }

}

