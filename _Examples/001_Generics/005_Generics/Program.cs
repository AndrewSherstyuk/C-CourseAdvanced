using System;

/// <summary>
/// Проблемы которые привели к созданию обобщенных типов
/// </summary>
namespace _005_Generics
{
    /// <summary>
    /// Класс сотрудник 
    /// </summary>
    class Employee
    {
        /// <summary>
        /// Табельный номер 
        /// (Вопрос какого типа может быть  Табельный номер, символьный или числовой,
        /// Напириме  на момент написания класса мы можем точно не знать, какой тип лучше 
        /// выбрать для хранения Табельного номера - строку или число.)
        /// 1-й варинт 
        /// Можно определить свойство PersonnelNumber как свойство типа object.
        /// </summary>
        public object PersonnelNumber { get; set; }

        /// <summary>
        /// Фамилия 
        /// </summary>
        public string Surname { get; set; }
    }
    class Program
    {
        static void Main()
        {
            // Создание экземпляров класса Employee
            // 1. Табельный номер типа строка
            Employee employee1 = new Employee() { PersonnelNumber = "   1а", Surname = "Petvor" };
           
            // 2. Табельный номер типа число
            Employee employee2 = new Employee() { PersonnelNumber = 2, Surname = "Ivanov" };

            // Вывод инфоррмации о типе PersonnelNumber
            // 1. System.String - Табельный номер типа строка
            Console.WriteLine(employee1.PersonnelNumber.GetType());
            
            // 2. System.Int32 - Табельный номер типа число
            Console.WriteLine(employee2.PersonnelNumber.GetType());

            // Решение является не очень оптимальным, так как в данном случае мы сталкиваемся 
            // с такими явлениями как упаковка (boxing) и распаковка (unboxing).

            // Упаковка в значения int в тип Object.
            employee2.PersonnelNumber = 1;

            // Чтобы обратно получить данные в переменную типов int, необходимо выполнить распаковку.
            int personnelNumber1 = (int)employee2.PersonnelNumber;
            Console.WriteLine(personnelNumber1);

            // Другая проблема - проблема безопасности типов.
            // Так, мы получим ошибку во время выполнения программы, если напишем следующим образом:
            // int personnelNumber2 = (int)employee1.PersonnelNumber;
            // Console.WriteLine(personnelNumber2);

            //Задержка
            Console.ReadKey();
        }
    }
}
