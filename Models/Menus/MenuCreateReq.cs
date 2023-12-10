namespace CoffeeShop2.Models.Menus
{
    public class MenuCreateReq
    {
        public string menuKey { get; set; } = default!;
        public string? Name { get; set; } = default;
        public string? Description { get; set; } = default;
        public double Price { get; set; } = default;
    }
}
