namespace CoffeeShop2.Models.Menus
{
    public class MenuResponse
    {
        public string? Id { get; set; } = default;
        public string menuCode { get; set; } = default!;
        public string? Name { get; set; } = default;
        public string? Description { get; set; } = default;
        public double Price { get; set; } = default;
    }
}
