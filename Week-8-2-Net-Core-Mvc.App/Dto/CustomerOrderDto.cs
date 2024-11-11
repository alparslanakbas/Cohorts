using Week_8_2_Net_Core_Mvc.App.Models;

namespace Week_8_2_Net_Core_Mvc.App.Dto
{
    public sealed record CustomerOrderDto
    (
        Customer Customer,
        List<Order> Orders
    );
}
