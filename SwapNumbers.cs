using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class SwapNumbers
    {
        public static void Swap<T>(T a, T b)
        {
            Console.WriteLine("Before Swap Values are :");
            Console.WriteLine($"value1 = {a}, value2 = {b}");

            T temp;
            temp = a;
            a = b; 
            b = temp;

            Console.WriteLine();
            Console.WriteLine("After Swap Values are :");
            Console.WriteLine($"value1 = {a}, value2 = {b}");
            Console.WriteLine();
        }
    }
}
