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
            Book<int> book1 = new Book<int>("Spartacus", 20);
            book1.Show();
            Console.WriteLine(new string('=', 30));

            Book<decimal> book2 = new Book<decimal>("Hamlet", 20.00m);
            book2.Show();
            Console.WriteLine(new string('=', 30));

            Book<double> book3 = new Book<double>("50 Shadows of Grey", 20.00);
            book2.Show();
            Console.WriteLine(new string('=', 30));

            Console.ReadKey();
        }
    }

    class Book<T>
    {
        private string name;
        private T price;

        public Book(string name, T price)
        {
            Name = name;
            Price = price;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public T Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public void Show()
        {
            Console.WriteLine($"The name of the book is {name}");
            Console.WriteLine($"The price of the book is {price}");
        }
    }
}
