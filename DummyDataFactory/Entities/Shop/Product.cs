using Entities.Settings;

namespace Entities.Shop
{
    public record Product
    {
        public int Id { get; set; }
        public UserApp UserApp { get; set; } = null!;
        public ProductCategory ProductCategory { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public decimal Price { get; set; }
        public int InitialStockCount { get; set; }
        public int CurrentStockCount { get; set; }
        public bool IsUse { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
