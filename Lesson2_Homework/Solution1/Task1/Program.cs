using System;
using System.Collections;
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
            Random rnd = new Random();

            int[] myArray = new int[20];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rnd.Next(1, 20);
            }

            MyList<int> myIntCollection = new MyList<int>();

            for (int i = 0; i < 20; i++)
            {
                myIntCollection.Add(rnd.Next(1, 20));
            }

            foreach (int item in myIntCollection)
            {
                Console.WriteLine(item);
            }

            //IEnumerable enumerable = myIntCollection as IEnumerable;
            //IEnumerator<int> enumerator = myIntCollection.GetEnumerator();

            ////MyList<int> myIntCollection = new MyList<int>();

            ////for (int i = 0; i < 20; i++)
            ////{
            ////    myIntCollection.Add
            ////}

            //while (enumerator.MoveNext())
            //{
            //    int el = (int)enumerator.Current;
            //    Console.WriteLine(el);
            //}

            //Console.ReadKey();
        }
    }
}
