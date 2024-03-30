using System.Collections.Generic;

namespace Assignment_03.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<int> Quantities { get; set; }
        public User User { get; set; }
    }
}
