using System;

/// <summary>
/// Проблему указанную в примере выше призваны устранить обобщенные типы
/// Обобщенные типы позволяют указать конкретный тип, который будет использоваться.
/// </summary>
namespace _006_Generics
{
    /// <summary>
    /// Класс сотрудник 
    /// Угловые скобки в описании class Employee <T> указывают, что класс является обобщенным, 
    /// а тип T, заключенный в угловые скобки, будет использоваться этим классом.
    /// параметр T в угловых скобках еще называется универсальным параметром, 
    /// так как вместо него можно подставить любой тип.
    /// </summary>
    class Employee<T>
    {
        /// <summary>
        /// Табельный номер 
        /// </summary>
        public T PersonnelNumber { get; set; }

        /// <summary>
        /// Фамилия 
        /// </summary>
        public string Surname { get; set; }
    }
    class Program
    {
        static void Main()
        {
            // Создание экземпляра класса Employee и в качестве 
            // параметра типа (тип Employee) передаем тип string.
            Employee<string> employee1 = new Employee<string>()
            { 
                PersonnelNumber = "   1а", 
                Surname = "Petvor" 
            };

            // Создание экземпляра класса Employee и в качестве 
            // параметра типа (тип Employee) передаем тип int.
            Employee<int> employee2 = new Employee<int>()
            { 
                PersonnelNumber = 2, 
                Surname = "Ivanov" 
            };

            // Вывод инфоррмации о типе PersonnelNumber
            // System.String
            Console.WriteLine(employee1.PersonnelNumber.GetType());
            // System.Int32
            Console.WriteLine(employee2.PersonnelNumber.GetType());

            // Упаковка не нужна, так как PersonnelNumber - типа int
            employee2.PersonnelNumber = 1;

            //Задержка
            Console.ReadKey();
        }
    }
}
