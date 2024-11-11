namespace Week_8_2_Net_Core_Mvc.App.Models
{
    public sealed class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string ProductName { get; set; }
        public required decimal Price { get; set; } = 0.0m;
        public required int Quantity { get; set; } 
    }
}
