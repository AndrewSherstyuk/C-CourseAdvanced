using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public delegate int myDelegate();
    public delegate double myAdvancedDelegate(myDelegate[] dels);

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            myDelegate del1 = () => rnd.Next(1, 100);
            myDelegate del2 = () => rnd.Next(1, 100);
            myDelegate del3 = () => rnd.Next(1, 100);

            myDelegate[] delsA = new myDelegate[] { del1, del2, del3 };

            myAdvancedDelegate del4 = (myDelegate[] dels) =>
            {
                double a = 0;
                for (int x = 0; x < dels.Length; x++)
                {
                    int b = dels[x].Invoke();
                    Console.WriteLine(b);
                    a += b;
                }
                return a / dels.Length;
            };

            Console.WriteLine(del4.Invoke(delsA));

            Console.ReadKey();
        }
    }
}
