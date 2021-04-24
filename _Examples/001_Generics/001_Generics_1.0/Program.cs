using System;

/// <summary>
/// Понятие упаковки и распаковки
/// упаковка - boxing;
/// распаковка - unboxing;
/// </summary>
namespace _001_Generics_1._0
{
    class Program
    {
        static void Main()
        {
            // Упаковка(Boxing) - преобразование структурного типа (типа значения) в ссылочный тип
            // (Object или любой другой тип интерфейса, реализуемый этим типом значения).
            // Когда тип значения упаковывается средой CLR, она создает программу-оболочку значения внутри

            // Значимый тип
            int valueTypes = 10;

            // 1) Упаковка переменной - valueTypes (Boxing).
            object referenceType = valueTypes;

            // 2) Распаковка объекта (UnBoxing).
            // Распаковка должна производиться только в тот тип, 
            // из которого производилась упаковка.
            // byte againValueTypes = (byte)referenceType;
            int againValueTypes = (int)referenceType;

            // Задержка
            Console.ReadKey();
        }
    }
}
