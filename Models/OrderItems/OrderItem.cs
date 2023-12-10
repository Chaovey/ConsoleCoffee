
using CoffeeShop2.Models.Items;
using CoffeeShop2.Models.Orders;
using ConsoleCoffee.Contracts;

namespace CoffeeShop2.Models.OrderItems
{
    public class OrderItem : IKey
    {
        public string Id { get; set; } = default!;
        public string orderItemId { get; set; }=default!;
        public int quantity { get; set; } = default;

        //Navigations
        public Order? order { get; set; } = default;
        public string orderId {  get; set; } = default!; //foreign key
        public Item? item { get; set; } = default;
        public string itemId { get; set; } = default!;  //foreign key
    }
}
