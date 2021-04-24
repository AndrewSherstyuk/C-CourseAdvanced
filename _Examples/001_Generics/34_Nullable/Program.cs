using System;

/// <summary>
/// System.Nullable<T>
/// Значение по умолчанию для NullableTypes == null.
/// </summary>
namespace _34_Nullable
{
    class Program
    {
        static int? i;
        static void Main()
        {
            if (i == null)
                Console.WriteLine("null");
            else if (i == 0)
                Console.WriteLine("0");
            else
                Console.WriteLine("Другое...");

            Console.WriteLine(new string('-', 10));

            Console.WriteLine(@"Значение по умлочнаю для int? = <{0}>", default(int?));
            Console.WriteLine(@"Значение по умлочнаю для int = <{0}>", default(int));

            // Задержка.
            Console.ReadKey();
        }
    }
}
