using Entities.Member;

namespace Entities.Shop
{
    public record Cart
    {
        public int Id { get; set; }
        public MemberUser MemberUser { get; set; } = null!;
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
