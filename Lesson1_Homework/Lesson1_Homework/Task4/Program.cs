using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? time = new DateTime(2021, 4, 14);
            time = null;

            if (time == null)
            {

            }

            //Мой ответ: Не является по той причине, что переменная time объявлена не как nullable. И являлось бы валидным в том случае, если бы time было объявлено как DateTime? time
        }
    }
}
