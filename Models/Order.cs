using System;
namespace Assignment_03.Models
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
        // Add any other properties relevant to the order
    }
}
