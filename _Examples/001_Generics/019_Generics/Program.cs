using System;

/// <summary>
/// Частичные классы (Напоминание).
/// Классы могут быть частичными. То есть мы можем иметь 
/// несколько файлов с определением одного и того же класса, 
/// и при компиляции все эти определения будут скомпилированы в одно
/// </summary>
namespace _019_Generics
{
    class Program
    {
        static void Main()
        {
            // Cоздаем екземпляр класса Person с именем ford
            Person person = new Person();
            person.Move();
            person.Eat();
            person.SomeMethod();

            // Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Первая часть класса Person
    /// </summary>
    public partial class Person
    {
        /// <summary>
        /// Метод Move
        /// </summary>
        public void Move()
        {
            Console.WriteLine("I am moving");
        }

        /// <summary>
        /// Частичный метод
        /// </summary>
        partial void PartialMethod();
    }

    /// <summary>
    /// Вторая часть класса Person
    /// </summary>
    public partial class Person
    {
        /// <summary>
        /// Метод Eat
        /// </summary>
        public void Eat()
        {
            Console.WriteLine("I am eating");
        }

        /// <summary>
        /// Частичный метод
        /// </summary>
        partial void PartialMethod()
        {
            Console.WriteLine("PartialMethod");
        }

        /// <summary>
        /// Обычный метод
        /// частичные методы не могут иметь модификаторов доступа 
        /// - по умолчанию они все считаются приватными. Для вызова 
        /// используем метод обертку
        /// </summary>
        public void SomeMethod()
        {
            PartialMethod();
        }
    }
}
