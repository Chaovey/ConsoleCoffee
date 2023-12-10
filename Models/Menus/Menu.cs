using CoffeeShop2.Models.Orders;
using ConsoleCoffee.Contracts;
namespace CoffeeShop2.Models.Menus
{
    public class Menu : IKey
    {
        public string Id { get; set; } = default!;
        public string menuId { get; set; } = default!;
        public string? Name { get; set; } = default;
        public string? Description { get; set; } = default;
        public double Price { get; set; } = default;
        //Navigationt
        public List<Order>? order { get; set; } = default;
    }
}