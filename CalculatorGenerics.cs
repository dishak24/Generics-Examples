using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class CalculatorGenerics
    {
            /*public static T Add<T> (T a, T b)
            {
                return a + b;
            }

            public static T Subtract<T>(T a, T b)
            {
                return a - b ;
            }*/

        public static void MenuDrivenCalculator <T> (T a, T b)
        {
            double num1 = Convert.ToDouble(a);
            double num2 = Convert.ToDouble(b);
            Console.WriteLine();

            double result;
                while (true)
                {
                    Console.WriteLine("1. Addition \n2. Subtraction \n3. Multiplication \n4. Division \n5. Exit ");
                    Console.WriteLine();
                    Console.WriteLine("Enter your Choice : ");
                    int ch = Convert.ToInt32(Console.ReadLine());

                    switch (ch)
                    {
                        case 1:
                            result = num1 + num2;
                            Console.WriteLine(num1 + " + " + num2 + " = " + result);
                            break;

                        case 2:
                            result = num1 - num2;
                            Console.WriteLine(num1 + " - " + num2 + " = " + result);
                            break;

                        case 3:
                            result = num1 * num2;
                            Console.WriteLine(num1 + " * " + num2 + " = " + result);
                            break;

                        case 4:
                            result = num1 / num2;
                            if (num2 == 0)
                            {
                                Console.WriteLine("you Cannot divide by 0 ");
                                break;
                            }
                            Console.WriteLine(num1 + " / " + num2 + " = " + result);
                            break;

                        case 5:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid Choice !!! ");
                            break;

                    }


                }
        
        }


    }
}

