using System;

/// <summary>
/// Оператор ?? называется оператором null-объединения.
/// Он также применим для ссылочних типов
/// </summary>
namespace _33_Nullable
{
    class Program
    {
        static void Main()
        {
            // x - содержит неизвестное значение.
            object x = null;
            object y = x ?? 100;  // равно 100, так как x равен null

            Console.WriteLine(y);

            Console.WriteLine(new string('-', 10));

            // Фактически равноценно следующему тернарному оператору:
            y = x == null ? 100 : x;

            Console.WriteLine(y);

            // Задержка.
            Console.ReadKey();
        }
    }
}
