using CoffeeShop2.Models.OrderItems;
using ConsoleCoffee.Contracts;
namespace CoffeeShop2.Models.Items
{
    public class Item : IKey
    {
        public string Id { get; set; } = default!;
        public string itemId { get; set; }=default!;
        public string? Name { get; set; } = default;
        public string? Description { get; set; } = default;
        public string? size { get; set; } = default;
        public List<OrderItem>? orderitem { get; set; } = default;
    }
}
