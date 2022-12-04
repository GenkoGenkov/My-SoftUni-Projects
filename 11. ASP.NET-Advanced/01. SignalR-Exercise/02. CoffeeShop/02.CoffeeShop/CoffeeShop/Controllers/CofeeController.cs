using CoffeeShop.Hubs;
using CoffeeShop.Models;
using CoffeeShop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace CoffeeShop.Controllers
{
    public class CofeeController : Controller
    {
        private readonly OrderService orderService;
        private readonly IHubContext<CofeeHub> coffeeHub;

        public CofeeController(
            OrderService _orderService, 
            IHubContext<CofeeHub> _coffeeHub)
        {
            orderService = _orderService;
            coffeeHub = _coffeeHub;
        }

        [HttpPost]
        public async Task<IActionResult> OrderCofee([FromBody] Order order)
        {
            await coffeeHub.Clients.All.SendAsync("NewOrder", order);
            var orderId = orderService.NewOrder();

            return Accepted(orderId);
        }
    }
}
