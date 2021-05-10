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
            Random rnd = new Random();

            List<int> myList = new List<int>();

            for (int i = 0; i < 30; i++)
            {
                myList.Add(rnd.Next(-50, 50));
            }

            List<int> myListPositives = new List<int>();

            foreach (int a in myList)
            {
                if (a > 0)
                {
                    myListPositives.Add(a);
                }
            }

            List<int> myListNegatives = new List<int>();

            foreach (int b in myList)
            {
                if (b < 0)
                {
                    myListNegatives.Add(b);
                }
            }

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.WriteLine(new string('=', 20));

            Console.WriteLine($"First positive is {myListPositives.FirstOrDefault()} \n" +
                $"Last negative is {myListNegatives.Last()}");

            Console.ReadKey();
        }
    }
}
