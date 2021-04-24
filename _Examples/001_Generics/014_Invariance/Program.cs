using System;

/// <summary>
/// Инвариантность: позволяет использовать только заданный тип
/// Понятия ковариантности и контравариантности связаны с возможностью использовать в приложении
/// вместо некоторого типа другой тип, который находится ниже или выше в иерархии наследования.
/// </summary>
namespace _014_Invariance
{
    /// <summary>
    /// Базовый класс Car
    /// </summary>
    public class Car { }

    /// <summary>
    /// Унаследованный класс Ford от класса Car
    /// </summary>
    public class Ford : Car { }

    /// <summary>
    /// Интерфейс IGarage параметризированный указателем места заполнения типа- Т
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGarage<T>
    {
        /// <summary>
        /// Автосвойство Вох - типа T
        /// </summary>
        T Вох { get; set; }
    }

    /// <summary>
    /// Класс Garage<T> параметризированный указателем места заполнения типа- Т,
    /// который реализует интерфейс  IGarage<T>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Garage<T> : IGarage<T>
    {
        /// <summary>
        /// Реализация автосвойства из интерфейс  IGarage<T>
        /// </summary>
        public T Вох { get; set; }

        /// <summary>
        /// Конструктор класса 
        /// </summary>
        public Garage(T bох)
        {
            this.Вох = bох;
        }
    }

    class Program
    {
        static void Main()
        {
            // Cоздаем екземпляр класса Ford с именем ford
            Ford ford = new Ford();

            // Cоздаем переменную garage типа базового интерфейсного типа IGarage, 
            // параметризированную указателем места заполнения типа- Car и в конструктор 
            // передаем переменную типы ford, хотя закрыли типом Car (UpCast типа)
            IGarage<Car> garage = new Garage<Car>(ford);

            // Выводим информацию о типе
            Console.WriteLine(garage.GetType().ToString());

            // Задержка
            Console.ReadKey();
        }
    }
}
