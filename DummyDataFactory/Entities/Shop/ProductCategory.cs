namespace Entities.Shop
{
    public record ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsUse { get; set; }
        public DateTime CreateDateTime { get; set; }
    }

}
