namespace CoffeeShop2.Models.Items
{
    public class ItemCreateReq
    {
        public string itemKey { get; set; } = default!;
        public string? Name { get; set; } = default;
        public string? Description { get; set; } = default;
        public string? size { get; set; } = default;
    }
}
