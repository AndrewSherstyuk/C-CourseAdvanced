using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double myNumber1;
            double myNumber2;

            Console.WriteLine("Please enter a numeric operand 1");
            string operand1 = Console.ReadLine();

            Console.WriteLine("Please enter a numeric operand 2");
            string operand2 = Console.ReadLine();

            if (!Double.TryParse(operand1, out myNumber1) || !Double.TryParse(operand2, out myNumber2))
            {                
                Console.WriteLine("Both operands should be numeric");
            }
            else
            {
                Calculator calc = new Calculator(myNumber1, myNumber2);

                Console.WriteLine("Please enter '*', '/', '+' or '-' depending on what you want to do");
                string operation = Console.ReadLine();

                switch(operation)
                {
                    case "*":
                        {
                            Console.WriteLine($"{calc.Multiply()}");
                            break;
                        }
                    case "/":
                        {
                            Console.WriteLine($"{calc.Divide()}");
                            break;
                        }
                    case "+":
                        {
                            Console.WriteLine($"{calc.Add()}");
                            break;
                        }
                    case "-":
                        {
                            Console.WriteLine($"{calc.Substract()}");
                            break;
                        }
                    default:
                        Console.WriteLine("We don't have such an operation");
                        break;
                }                
            }

            Console.ReadKey();
        }
    }

    class Calculator
    {
        public dynamic Operand1 { get; set; }
        public dynamic Operand2 { get; set; }

        public Calculator(dynamic operand1, dynamic operand2)
        {
            Operand1 = operand1;
            Operand2 = operand2;
        }

        public dynamic Add()
        {
            return Operand1 + Operand2; 
        }

        public dynamic Substract()
        {
            return Operand1 - Operand2;
        }

        public dynamic Divide()
        {            
            return Operand1 / Operand2;
        }

        public dynamic Multiply()
        {
            return Operand1 * Operand2;
        }
    }
}
