using CoffeeShop2.Models.Customers;
using CoffeeShop2.Models.Menus;
using CoffeeShop2.Models.OrderItems;
using CoffeeShop2.Models.Payments;
using ConsoleCoffee.Contracts;
using System.Text.Json.Serialization;
namespace CoffeeShop2.Models.Orders
{
    public class Order : IKey
    {
        public string Id { get; set; } = default!;
        public string orderId { get; set; } = default!;
        public string? orderStatus { get; set; } = default;
        public double Price { get; set; } = default;


        //Navvigations
        public Menu? menus { get; set; } = default;
        public string MenuId { get; set; }=default!; // fereign key
        public Customer? customer { get; set; } = default;
        public string CustomerId { get; set; }=default!; //fereign key
        public List<Payment>? payment { get; set; } = default;
        public List<OrderItem>? orderItem { get; set; } = default;
    }
}
