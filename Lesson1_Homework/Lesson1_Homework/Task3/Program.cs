using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator<int, int> calc1 = new Calculator<int, int>(2, 5);
            Console.WriteLine($"{calc1.Sum()} \n{calc1.Diff()} \n{calc1.Prod()} \n{calc1.Quot()}");
            Console.WriteLine($"{ new string('=', 15)} \n");

            Calculator<double, int> calc2 = new Calculator<double, int>(2, 5);
            Console.WriteLine($"{calc2.Sum()} \n{calc2.Diff()} \n{calc2.Prod()} \n{calc2.Quot()}");
            Console.WriteLine($"{ new string('=', 15)} \n");

            Calculator<decimal, long> calc3 = new Calculator<decimal, long>(2m, 5);
            Console.WriteLine($"{calc3.Sum()} \n{calc3.Diff()} \n{calc3.Prod()} \n{calc3.Quot()}");
            Console.WriteLine($"{ new string('=', 15)} \n");

            Console.ReadKey();
        }
    }

    class Calculator<T1, T2>
    {
        private double operand1;
        private double operand2;

        public Calculator(T1 operand1, T2 operand2)
        {
            try
            {
                this.operand1 = Convert.ToDouble(operand1);
                this.operand2 = Convert.ToDouble(operand2);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        public double Sum()
        {
            return operand1 + operand2;
        }
        public double Diff()
        {
            return operand1 - operand2;
        }
        public double Prod()
        {
            return operand1 * operand2;
        }
        public double Quot()
        {
            try
            {
                return operand1 / operand2;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return default(double);
            }
        }

    }
}
