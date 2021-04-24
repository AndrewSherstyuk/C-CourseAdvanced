using System;

/// <summary>
/// Обобщение
/// Ограничения параметров типа
/// new()  -  Аргумент типа должен иметь открытый конструктор 
/// без параметров.
/// </summary>
namespace _24_Constrain
{
    class Program
    {
        static void Main()
        {
            MyClass<User> myClass = new MyClass<User>();

            myClass.instance.Name = "Alexs";
            myClass.instance.Age = 27;

            myClass.GetValues();

            // Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс MyClass
    /// where T : new()  -  Аргумент типа должен иметь открытый конструктор без параметров.
    /// </summary>
    class MyClass<T> where T : new()
    {
        public T instance = new T();

        public void GetValues()
        {
            Console.WriteLine(instance.ToString());
        }
    }

    /// <summary>
    /// Класс UserClass
    /// </summary>
    class User
    {
        public string Name { get; set; }

        public int Age { get; set; }
        
        public override string ToString()
        {
            return string.Format("Name - {0}, Age - {1}", Name, Age);
        }
    }
}
