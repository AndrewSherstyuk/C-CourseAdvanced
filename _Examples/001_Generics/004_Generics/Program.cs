using System;

/// <summary>
/// Проблемы с безопасностью типов
/// </summary>
namespace _004_Generics
{
    class Program
    {
        static void Main()
        {
            // Создаем массив элементов  типа object
            object[] arrayObject = new object[4];

            // object[] может хранить все что угодно.
            // контейнер arrayObject хранит произвольные фрагменты несвязанных
            arrayObject[0] = true;
            arrayObject[1] = 66;
            arrayObject[2] = new OperatingSystem(PlatformID.MacOSX, new Version(10,0));
            arrayObject[3] = 3.14;

            // В некоторых случаях действительно необходим исключительно гибкий контейнер,
            // который может хранить буквально все.Однако в большинстве ситуаций понадобится
            // безопасный в отношении типов контейнер, который может оперировать только 
            // определенным типом данных
            
            for (int i = 0; i < arrayObject.Length; i++)
            {
                // т.к. arrayObject может хранить все что угодно, не знаем какото типа элмент
                Console.WriteLine(arrayObject[i]);
            }

            // Задержка
            Console.ReadLine();
        }
    }
}
