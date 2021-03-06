using System;

/// <summary>
/// На первый взгляд упаковка/распаковка может показаться несущественным средством языка, 
/// представляющим академический интерес. На самом деле процесс упаковки/распаковки очень полезен, 
/// поскольку позволяет предположить, что все можно трактовать как System.Object, причем CLR
/// берет на себя все заботы о деталях, связанных с памятью.
/// </summary>
namespace _003_Generics
{
    class Program
    {
        static void Main()
        {
            // Создаем массив элементов  типа object
            object[] arrayObject = new object[3];

            // Происходит неявная упаковка
            // Типы эначений автоматически упаковываются, когда
            // передаются члену, принимающему объект.
            arrayObject[0] = 10;
            arrayObject[1] = 20;
            arrayObject[2] = 35;

            // Попытка распаковки (должна быть явной)
            // int j = arrayObject[1];

            // Распаковка происходит, когда объект преобразуется
            // обратно в расположенные в стеке данные.
            int i = (int)arrayObject[1];

            // Теперь значение вновь упаковывается, т.к. WriteLine() требует объектные типы!
            Console.WriteLine("Значение вашего int: {0}", i);

            // Задержка
            Console.ReadKey();
        }
    }
}
