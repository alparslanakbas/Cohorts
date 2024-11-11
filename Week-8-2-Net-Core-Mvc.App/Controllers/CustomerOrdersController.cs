using Microsoft.AspNetCore.Mvc;
using Week_8_2_Net_Core_Mvc.App.Dto;
using Week_8_2_Net_Core_Mvc.App.Models;

namespace Week_8_2_Net_Core_Mvc.App.Controllers
{
    public class CustomerOrdersController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {

            var customerOrderDto = new CustomerOrderDto
            (
                new Customer
                {
                    FirstName = "Alparslan",
                    LastName = "Akbaş",
                    Email = "alparslan@gmail.com"
                },
                
                new List<Order>
                {
                    new Order
                    {
                        ProductName = "Lenovo Legion 7 Pro",
                        Price = 1000.0m,
                        Quantity = 10
                    },
                    new Order
                    {
                        ProductName = "Lenovo Legion R27FC30 Monitor",
                        Price = 500.0m,
                        Quantity = 15
                    },

                    new Order
                    {
                        ProductName = "Amd Ryzen 7 5700X3D",
                        Price = 300.0m,
                        Quantity = 20
                    }
                }

                );

            return View(customerOrderDto);
        }
    }
}
