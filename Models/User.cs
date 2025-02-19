﻿using System.Collections.Generic;
namespace Assignment_03.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public ICollection<Order> PurchaseHistory { get; set; }
        public string ShippingAddress { get; set; }
    }
}
