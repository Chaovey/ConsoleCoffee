using CoffeeShop2.Models.Customers;
using CoffeeShop2.Models.Menus;
namespace CoffeeShop2.Models.Orders
{
    public class OrderUpdateReq
    {
        public string Id { get; set; } = default!;
        public string orderKey { get; set; } = default!;
        public string? ordderStatus { get; set; } = default;
        public double Price { get; set; } = default;
        public string MenuId { get; set; } = default!;
        public string CustomerId { get; set; }=default!;
    }
}
