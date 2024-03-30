using System;
namespace Assignment_03.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
        public int Rating { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
    }
}
