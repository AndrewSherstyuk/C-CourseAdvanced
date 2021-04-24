using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Array;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            MyList<int> myIntCollection = new MyList<int>();

            for (int i = 0; i < 20; i++)                                                    // Testing Add() method
            {
                myIntCollection.Add(rnd.Next(1, 20));
            }

            Console.WriteLine("Collection initialized");

            foreach (var item in (IEnumerable)myIntCollection)
            {
                Console.WriteLine(item);
            }            

            if (myIntCollection.Contains(8))                                                // Testing Contains() method 1
                Console.WriteLine("The list above contains 8");
            else 
                Console.WriteLine("The list above doesn't contain 8 this time"); 

            Console.WriteLine(new String('=', 50));

            if (!myIntCollection.Contains(75))                                              // Testing Contains() method 2
                Console.WriteLine("The list above cannot ever contain 75");

            Console.WriteLine(new String('=', 50));

            myIntCollection.Clear();                                                        // Testing Clear() method
            Console.WriteLine("Collection cleared");

            Console.WriteLine(new String('=', 50));

            for (int i = 0; i < 10; i++)                                                    // Testing Add() method again
            {
                myIntCollection.Add(rnd.Next(1, 20));
            }

            Console.WriteLine("Collection filled in with elements again");

            foreach (int item in (IEnumerable)myIntCollection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new String('=', 50));

            Console.WriteLine($"{myIntCollection[5]}");                                     // Testing T this[int index] field

            Console.WriteLine(new String('=', 50));
            Console.WriteLine("EXTENTION METHOD 1");

            int a = 12;
            int b = 13;
            int c = 14;
            int d = 15;
            int e = 16;

            int[] extended_1 = Extender.GetArray<int>(myIntCollection, a, b, c, d, e);      // Testing T[] GetArray<T> method used traditionally
            foreach (int item in extended_1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new String('=', 50));
            Console.WriteLine("EXTENTION METHOD 2");

            int[] newItems = new int[] { 17, 18, 19, 20, 21 };
            int[] extended_2 = myIntCollection.GetArray(newItems);                          // Testing T[] GetArray<T> method used pure Extention method
            foreach (int item in extended_2)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
