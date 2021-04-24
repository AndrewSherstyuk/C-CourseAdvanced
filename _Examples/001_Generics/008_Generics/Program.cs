using System;

/// <summary>
/// Свойства (Напоминание)
/// Кроме обычных методов в языке C# предусмотрены специальные методы доступа, которые называют свойства. 
/// Они обеспечивают простой доступ к полям классов и структур, узнать их значение или выполнить их установку.
/// </summary>
namespace _008_Generics
{
    class Program
    {
        static void Main()
        {
            // Создаем экземпляр класса MyClass
            MyClass myClass = new MyClass();

            // Присваиваем свойству Name значение SomeName
            myClass.Name = "SomeName";

            // Поучаем значения свойства Name
            Console.WriteLine(myClass.Name);
            
            // Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс MyClass
    /// 
    class MyClass
    {
        /// <summary>
        /// Закрытое поле name
        /// </summary>
        private string name;

        /// <summary>
        /// Общедоступное свойство Name
        /// </summary>
        public string Name
        {
            // Блок get (Получение значения)
            get
            {
                return name;
            }

            // Блок set - (Установка значения)
            set
            {
                name = value;
            }
        }
    }
}
