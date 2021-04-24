using System;
using System.Collections;
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
            SortedList<string, string> mySortedList = new SortedList<string, string>();

            mySortedList.Add("Ben", "Gunn");
            mySortedList.Add("Vasil", "Bykov");
            mySortedList.Add("Alex", "Dumas");
            mySortedList.Add("Sid", "Visious");
            mySortedList.Add("Cally", "Blunsh");

            foreach (var item in mySortedList)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }           

            Console.WriteLine("\n" + new String('=', 20) + "\n");

            foreach (var item in mySortedList.Reverse())
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            } 

            Console.ReadKey();
        }

    }
}
