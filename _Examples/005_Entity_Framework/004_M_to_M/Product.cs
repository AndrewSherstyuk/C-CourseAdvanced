using System.Collections.Generic;

namespace _004_M_to_M
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public ICollection<Order> Order { get; set; }
        public Product()
        {
            Order = new List<Order>();
        }
    }
}
