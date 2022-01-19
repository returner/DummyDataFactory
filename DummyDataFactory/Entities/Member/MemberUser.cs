using Entities.Settings;

namespace Entities.Member
{
    public record MemberUser
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string MemberKey { get; set; } = null!;
        public UserApp UserApp { get; set; } = null!;
        public bool IsActivate { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
