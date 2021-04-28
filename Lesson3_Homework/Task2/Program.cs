using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public delegate double myDelegate(double a, double b);

    class Program
    {
        static void Main(string[] args)
        {
            myDelegate delSum = (double a, double b) => a + b;
            myDelegate delDif = (double a, double b) => a - b;
            myDelegate delProd = (double a, double b) => a * b;
            myDelegate delQuot = (double a, double b) =>
            {
                if (b != 0)
                    return a / b;
                else
                {
                    Console.WriteLine("Cannot divide by zero");
                    return 0;
                }
            };

            while (true)
            {
                Console.WriteLine("Please enter operand 1");
                double x = Double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter operand 2");
                double y = Double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter operation: '*' to multiply, '/' to divide, '+' to sum, '-' to substract or any other key to exit");
                string z = Console.ReadLine();

                switch (z)
                {
                    case "*":
                        Console.WriteLine($"{delProd(x, y)}");
                        break;
                    case "/":
                        Console.WriteLine($"{delQuot.Invoke(x, y)}");
                        break;
                    case "+":
                        Console.WriteLine($"{delSum(x, y)}");
                        break;
                    case "-":
                        Console.WriteLine($"{delDif.Invoke(x, y)}");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
