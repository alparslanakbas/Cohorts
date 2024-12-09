namespace Week_12_Code_First.Library.Models
{
    internal class Movie
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Title { get; set; }
        public required string Genre { get; set; }
        public required int ReleaseYear { get; set; }
    }
}
