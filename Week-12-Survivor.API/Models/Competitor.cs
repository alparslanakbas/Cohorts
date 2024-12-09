namespace Week_12_Survivor.API.Models
{
    public class Competitor : BaseEntity<Guid>
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}
