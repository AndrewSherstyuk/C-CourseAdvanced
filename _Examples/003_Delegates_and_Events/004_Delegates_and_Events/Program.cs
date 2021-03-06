using System;

/// <summary>
/// Делегат 
/// Делегаты представляют такие объекты, которые указывают на методы. То есть 
/// делегаты - это указатели на методы и с помощью делегатов мы можем вызвать данные методы.
/// </summary>
namespace _004_Delegates_and_Events
{
    class Program
    {
        /// <summary>
        /// 1. Создаем класс делегата.
        /// Для объявления делегата используется ключевое слово delegate,
        /// после которого идет возвращаемый тип, название и параметры.
        /// Класс-делегата с именем MyDelegate,
        /// метод, который будет сообщен с экземпляром данного класса-делегата, 
        /// не будет ничего принимать и не будет ничего возвращать.
        /// </summary>
        public delegate void MyDelegate();
        static void Main()
        {
            // 2. Создаем экземпляр делегата.
            MyDelegate myDelegate = new MyDelegate(MyClass.Method);

            // 3. Вызываем метод сообщенный с делегатом.
            myDelegate.Invoke();

            // 4. Другой способ вызова метода сообщенного с делегатом
            // без указания Invoke(), менее очевидно. 
            myDelegate();

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс, метод которого будет сообщен с делегатом.
    /// static - класс 
    /// </summary>
    static class MyClass
    {
        /// <summary>
        /// Создаем статический метод, который планируем сообщить с делегатом.
        /// static - метод
        /// </summary>
        public static void Method()
        {
            Console.WriteLine("Строку вывел метод сообщенный с делегатом.");
        }
    }
}
