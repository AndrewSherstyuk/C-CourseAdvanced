using System;

/// <summary>
/// Понятие упаковки и распаковки
/// упаковка - boxing;
/// распаковка - unboxing;
namespace _002_Generics
{
    class Program
    {
        static void Main()
        {
            // Значимый тип
            int valueTypes = 10;

            // 1) Упаковка переменной - valueTypes (Boxing).
            object referenceType = valueTypes;

            // 2) Попытка Распаковки объекта в другой тип 
            // (не из которого производилась упаковка).

            try
            {
                long againValueTypes = (long)referenceType;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Задержка
            Console.ReadKey();
            
        }
    }
}
