using System;

/// <summary>
/// Автоматические свойства (Напоминание)
/// Свойства управляют доступом к полям класса. Но, если учитывать большое количество полей,
/// то определять каждое поле и писать для него однотипное свойство было бы утомительно.
/// Поэтому в фреймворк .NET были добавлены автоматические свойства.
/// </summary>
namespace _009_Generics
{
    class Program
    {
        static void Main()
        {
            // Создаем экземпляр класса MyClass
            MyClass myClass = new MyClass();

            // Присваиваем свойству MyProperty1 значение 1
            myClass.MyProperty1 = 1;

            // Присваиваем свойству MyProperty2 значение SomeName
            myClass.MyProperty2 = "SomeName";

            // Поучаем значения свойства MyProperty1
            Console.WriteLine(myClass.MyProperty1);

            // Поучаем значения свойства MyProperty2
            Console.WriteLine(myClass.MyProperty2);

            // Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс MyClass
    /// </summary>
    class MyClass
    {
        /// <summary>
        /// Aвтоматическое свойство MyProperty1  типа int
        /// </summary>
        public int MyProperty1 { get; set; }

        /// <summary>
        /// Aвтоматическое свойство MyProperty2  типа string
        /// </summary>
        public string MyProperty2 { get; set; }
    }
}
