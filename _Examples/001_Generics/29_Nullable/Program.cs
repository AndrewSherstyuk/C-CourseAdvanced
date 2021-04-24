using System;

/// <summary>
/// Ссылочные типы
/// Одно из отличий ссылочных типов от типов значений состоит 
/// в том, что переменные ссылочных типов могут принимать 
/// значение null.
/// </summary>
namespace _29_Nullable
{
    class Program
    {
        static void Main()
        {
            // Если переменным ссылочного типа не присваивается 
            // значение, то им дается значение по умолчанию -значение null.Фактически оно говорит об отстутсвии значения как такового.
            object o = null;
            string s = null;

            Console.WriteLine(o);
            Console.WriteLine(s);

            // Опасность!
            MyClass myClass = new MyClass();
            myClass.MyProperty = "MyProperty";
           
            myClass = null;

            try
            {
                Console.WriteLine(myClass.MyProperty);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
    /// <summary>
    /// Класс MyClass
    /// </summary>
    class MyClass
    {
        /// <summary>
        /// MyProperty
        /// </summary>
        public string MyProperty { get; set; }
    }
}
