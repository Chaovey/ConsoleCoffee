using CoffeeShop2.Models.Customers;
using CoffeeShop2.Models.Orders;
using ConsoleCoffee.Contracts;

namespace CoffeeShop2.Models.Payments
{
    public class Payment : IKey
    {
        public string Id { get; set; } = default!;
        public string paymentId { get; set; } = default!;
        public double paymentAmount { get; set; } = default;
        public DateTime? paymentDate { get; set; } = default;

        //Naviagations
        public Customer? customers { get; set; } = default;
        public string CustomerId { get; set; }=default!; // foreign key
        public Order? orders { get; set; } = default;
        public string orderId { get; set; } = default!; // fereign key
    }
}
