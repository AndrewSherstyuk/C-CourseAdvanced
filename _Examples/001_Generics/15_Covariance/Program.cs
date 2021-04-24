using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Ковариантность обобщений.
/// Ковариантность: позволяет использовать более конкретный тип, чем заданный изначально.
/// Обобщенные интерфейсы могут быть ковариантными, если к универсальному параметру 
/// применяется ключевое слово out. 
/// </summary>
namespace _15_Covariance
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
    /// out - ключевое слово для ковариантности обобщений.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGarage<out T>
    {
        /// <summary>
        /// Автосвойство Вох - типа T
        /// </summary>
        T Вох { get; }
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
            // параметризированную указателем места заполнения типа- Ford и в конструктор 
            // передаем переменную типы ford, хотя закрыли типом Car (UpCast типа)
            IGarage<Car> garage = new Garage<Ford>(ford);

            // Выводим информацию о типе
            Console.WriteLine(garage.GetType().ToString());

            // Задержка
            Console.ReadKey();
        }
    }
}
