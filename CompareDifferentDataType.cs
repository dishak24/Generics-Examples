using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class CompareDifferentDataType
    {
        
        public static void CompareType<T> (T x, T y)
        {
            if ((x.ToString().CompareTo(y.ToString())) == 0)
            {
                Console.WriteLine($"{x} is equal to {y}");
            }
            else if ((x.ToString().CompareTo(y.ToString())) < 0)
            {
                Console.WriteLine($"{x} is smaller than {y}");
            }
            else
            {
                Console.WriteLine($"{x} is greater than {y}");
            }
        }

    }   
}
