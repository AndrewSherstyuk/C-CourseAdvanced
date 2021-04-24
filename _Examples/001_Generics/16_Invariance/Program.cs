using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  Контравариантность обобщений.
///  Контравариантность: позволяет использовать более универсальный тип, чем заданный изначально.
///  Для создания контравариантного интерфейса надо использовать ключевое слово in.
/// </summary>
namespace _16_Contravariance
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
    public interface IGarage<in T>
    {
        /// <summary>
        /// Автосвойство Вох - типа T
        /// </summary>
        T Вох { set; }
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
            // Cоздаем екземпляр класса Car с именем car (upcast)
            Car car = new Ford();

            IGarage<Ford> garage = new Garage<Car>(car);

            // Выводим информацию о типе
            Console.WriteLine(garage.ToString());

            // Задержка
            Console.ReadKey();
        }
    }
}
