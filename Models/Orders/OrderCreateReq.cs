using CoffeeShop2.Models.Customers;
using CoffeeShop2.Models.Menus;
using System.Text.Json.Serialization;
namespace CoffeeShop2.Models.Orders
{
    public class OrderCreateReq
    {
        public string orderKey { get; set; } = default!;
        public string? orderStatus { get; set; } = default;
        public double Price { get; set; } = default;
        public string MenuId { get; set; }=default!;
        public string CustomerId { get; set; } = default!;
    }
}
