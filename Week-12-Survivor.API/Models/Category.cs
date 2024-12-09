namespace Week_12_Survivor.API.Models
{
    public class Category : BaseEntity<Guid>
    {
        public required string Name { get; set; }
        public ICollection<Competitor> Competitors { get; set; }
    }
}
