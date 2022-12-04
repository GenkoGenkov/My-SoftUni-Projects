using CoffeeShop.Models;
using CoffeeShop.Services;
using Microsoft.AspNetCore.SignalR;

namespace CoffeeShop.Hubs
{
    public class CofeeHub : Hub
    {
        private readonly OrderService orderService;

        public CofeeHub(OrderService orderService)
        {
            this.orderService = orderService;
        }

        public async Task GetUpdateForOrder(int orderId)
        {
            CheckResult result;

            do
            {
                result = orderService.GetUpdate(orderId);

                if (result.New)
                {
                    await Clients.Caller.SendAsync("ReceiveOrderUpdate", result.Update);
                }

            } while (!result.Finished);

            await Clients.Caller.SendAsync("Finished");
        }
    }
}
