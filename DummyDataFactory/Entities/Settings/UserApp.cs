namespace Entities.Settings
{
    public record UserApp
    {
        public int Id { get; set; }
        public User User { get; set; } = null!;
        public string AppName { get; set; } = null!;
        public string ClientKey { get; set; } = null!;
        public AppType? AppType { get; set; }
        public AppConcept? AppConcept { get; set; }
        public bool IsUse { get; set; }
        public DateTime ExpireDateTime { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
