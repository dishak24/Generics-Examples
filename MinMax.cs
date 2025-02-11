using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MinMax
    {
        public static void FindMax<T>(T x, T y, T z) where T : IComparable<T>
        {
            T max = x;

            if (y.CompareTo(max) > 0)
                max = y;

            if (z.CompareTo(max) > 0)
                max = z;

            Console.WriteLine($"{max} is Maximum");
            

        }


        public static void FindMin<T>(T x, T y, T z) where T : IComparable<T>
        {

            T min = x;

            if (y.CompareTo(min) < 0)
                min = y;

            if (z.CompareTo(min) < 0)
                min = z;

            Console.WriteLine($"{min} is Minimum");
        }
    }
}
