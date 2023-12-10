namespace CoffeeShop2.Models.Customers
{
    public class CustomerResponse
    {
        public string? Id { get; set; } = default;
        public string customerCode { get; set; } = default!;
        public string? Name { get; set; } = default;
        public string? Phone { get; set; } = default;
        public int Order_history { get; set; } = default;
    }
}
