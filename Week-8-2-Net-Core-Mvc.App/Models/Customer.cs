namespace Week_8_2_Net_Core_Mvc.App.Models
{
    public sealed class Customer
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
    }
}
