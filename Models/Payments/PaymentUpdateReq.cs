namespace CoffeeShop2.Models.Payments
{
    public class PaymentUpdateReq
    {
        public string Id { get; set; } = default!;
        public string paymentKey { get; set; } = default!;
        public double paymentAmount { get; set; } = default;
        public DateTime? paymentDate { get; set; } = default;
        public string CustomerId { get; set; } = default!;
        public string orderId { get; set; } = default!;
    }
}
