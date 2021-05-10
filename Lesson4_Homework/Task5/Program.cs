using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<dynamic> englishRussianPairs = new List<dynamic>
            {
                new { english = "pencil", russian = "карандаш" },
                new { english = "animal",  russian = "животное" },
                new { english = "task", russian = "задача" },
                new { english = "tree", russian = "дерева" },
                new { english = "kitchen", russian = "кухня" },
                new { english = "house", russian = "дом" },
                new { english = "street", russian = "улица" },
                new { english = "song", russian = "песня" },
                new { english = "course", russian = "курс" },
                new { english = "weapon", russian = "оружие" }    
            };

            foreach(var a in englishRussianPairs)
            {
                Console.WriteLine($"{a.english}\t - \t{a.russian}"); 
            }

            Console.ReadKey();
        }
    }
}
