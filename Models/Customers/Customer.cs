using CoffeeShop2.Models.Orders;
using CoffeeShop2.Models.Payments;
using ConsoleCoffee.Contracts;
namespace CoffeeShop2.Models.Customers
{
    public class Customer : IKey
    {
        public string Id { get; set; } = default!;
        public string CustomerId { get; set; } = default!;
        public string? Name { get; set; } = default;
        public string? Phone { get; set; } = default;
        public int Order_history { get; set; } = default;
        //Navigations
        public List<Order>? order { get; set; } = default;
        public Payment? payment { get; set; } = default;
    }
}
