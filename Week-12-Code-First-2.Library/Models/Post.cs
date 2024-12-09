namespace Week_12_Code_First_2.Library.Models
{
    internal class Post
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required string UserId { get; set; }
        public User User { get; set; }
    }
}
