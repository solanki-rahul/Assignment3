namespace Assignment3.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();
        public int UserId { get; set; }
        public User User { get; set; } = new User();
        public int Rating { get; set; }
        public string? Image { get; set; } 
        public string? Text { get; set; } 
    }
}
