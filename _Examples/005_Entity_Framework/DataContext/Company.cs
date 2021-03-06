using System.Collections.Generic;

namespace DataContext
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Phone> Phones { get; set; }

        public Company()
        {
            Phones = new List<Phone>();
        }
    }
}
