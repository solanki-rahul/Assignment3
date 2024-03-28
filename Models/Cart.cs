﻿namespace Assignment3.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();
        public int Quantity { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = new User();
    }
}
