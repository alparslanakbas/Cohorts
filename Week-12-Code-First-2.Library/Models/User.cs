namespace Week_12_Code_First_2.Library.Models
{
    internal class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Username { get; set; }
        public required string Email { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
