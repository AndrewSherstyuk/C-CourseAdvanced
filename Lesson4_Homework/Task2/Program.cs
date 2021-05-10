using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Car() { Brand = "Ford", Model = "Focus", Color = "Red", ProdYear = 2020 },
                new Car() { Brand = "Ford", Model = "Figo", Color = "Blue", ProdYear = 2021 },
                new Car() { Brand = "Ford", Model = "Fiesta", Color = "Yellow", ProdYear = 2019 },
                new Car() { Brand = "Ford", Model = "Fusion", Color = "Blue", ProdYear = 2020 },
                new Car() { Brand = "Ford", Model = "Flex", Color = "Black", ProdYear = 2018 }
            };

            List<CarOwner> carOwners = new List<CarOwner>
            {
                new CarOwner() { Model = "Focus", Surname = "Johnson", PhoneNumber = 0971111111 },
                new CarOwner() { Model = "Focus", Surname = "Peterson", PhoneNumber = 0972222222 },
                new CarOwner() { Model = "Fiesta", Surname = "Yatts", PhoneNumber = 0973333333 },
                new CarOwner() { Model = "Fusion", Surname = "Lee", PhoneNumber = 0973333333 },
                new CarOwner() { Model = "Flex", Surname = "Thompson", PhoneNumber = 0975555555 }
            };

            var query = (from cO in carOwners
                         join c in cars
                         on cO.Model equals c.Model
                         select new
                         {
                             OwnerSurname = cO.Surname,
                             OwnerPhoneNumber = cO.PhoneNumber,
                             CarBrand = c.Brand,    
                             CarModel = c.Model,
                             CarProdYear = c.ProdYear,
                             CarColor = c.Color
                         }).ToList();

            var cOwner = query.Where(x => x.OwnerSurname == "Lee2").FirstOrDefault();

            if (cOwner != null)
            {
                Console.WriteLine($"{cOwner.OwnerSurname}, {cOwner.OwnerPhoneNumber}: {cOwner.CarBrand}, {cOwner.CarModel}, {cOwner.CarProdYear}, {cOwner.CarColor}");
            }
            else
            {
                Console.WriteLine("There's no such a car owner in the list");
            }

            Console.ReadKey();
        }
    }
}
