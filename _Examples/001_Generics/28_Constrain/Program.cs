using System;

/// <summary>
/// Обобщение
/// Ограничения параметров типа - "naked"
/// </summary>
namespace _28_Constrain
{
    class Program
    {
        static void Main()
        {
            MyClass<int, Object, int> my1 = new MyClass<int, Object, int>();

            MyClass<string, Object, string> my2 = new MyClass<string, Object, string>();

            // Не совпадают первый и третий аргументы типов - T и U (string и int).
            // ОШИБКА!  
            // MyClass<string, Object, int> my2 = new MyClass<string, Object, int>();
        }
    }

    /// <summary>
    /// Аргумент типа, предоставляемый в качестве T, 
    /// должен совпадать с аргументом, предоставляемым в 
    /// качестве U, или быть производным от него.
    /// Это называется ограничением типа "Naked".
    /// </summary>
    class MyClass<T, R, U> where T : U { }
}
