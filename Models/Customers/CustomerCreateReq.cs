namespace CoffeeShop2.Models.Customers
{
    public class CustomerCreateReq
    {
        public string customerKey { get; set; } = default!;
        public string? Name { get; set; } = default;
        public string? Phone { get; set; } = default;
        public int Order_history { get; set; } = default;
    }
}
