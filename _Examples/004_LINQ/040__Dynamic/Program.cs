using System;

/// <summary>
/// Динамические типы данных. 
/// Наследование
/// </summary>
namespace _040__Dynamic
{
    class Program
    {
        static void Main()
        {
            dynamic instance = new Derived();

            // Динамические поля должны быть проинициализированны перед использованием.
            instance.field = "Hello";

            Console.WriteLine(instance.Method());

            // Задержка.
            Console.ReadKey();
        }
    }

    class Base
    {
        public dynamic field;
        public dynamic Method()
        {
            return this.field;
        }
    }

    class Derived : Base { }
}
