namespace Entities.Shop
{
    public record OrderItem
    {
        public int Id { get; set; }
        public ICollection<Product>? Products { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
