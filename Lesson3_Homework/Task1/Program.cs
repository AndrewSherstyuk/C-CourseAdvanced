using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public delegate double myDelegate(int a, int b, int c);
    
    class Program
    {
        static void Main(string[] args)
        {
            myDelegate del = delegate (int a, int b, int c) { return (double)(a + b + c) / 3; };

            double x = del.Invoke(2, 3, 5);

            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
