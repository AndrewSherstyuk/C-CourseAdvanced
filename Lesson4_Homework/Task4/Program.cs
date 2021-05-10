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
            Random rnd = new Random();
            FitnessClient[] clients = new FitnessClient[10];

            for (int i = 0; i < clients.Length; i++)
            {
                clients[i] = myFactoryMethod();
            }

            for (int i = 0; i < clients.Length; i++) 
            {
                Console.WriteLine($"{clients[i].ClientId} \n{clients[i].Year} \n{clients[i].Month} \n{clients[i].TrainingHours} \n{new string('=', 20)}");
            }

            var targetObject = clients.OrderByDescending(x => x.TrainingHours).Select(x => new { x.TrainingHours, x.Year, x.Month }).Last();
            Console.WriteLine($"\nT A R G E T  O B J E C T \n{targetObject.TrainingHours} \n{targetObject.Year} \n{targetObject.Month}");

            FitnessClient myFactoryMethod()
            {
                FitnessClient client = new FitnessClient()
                {
                    ClientId = rnd.Next(1000000, 2000000),
                    Year = rnd.Next(1950, 2015),
                    Month = rnd.Next(1, 12),
                    TrainingHours = rnd.Next(1, 4)
                };
                return client;
            }

            Console.ReadKey();
        }
    }

    public class FitnessClient
    {
        public int ClientId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int TrainingHours { get; set; }
    }
}
