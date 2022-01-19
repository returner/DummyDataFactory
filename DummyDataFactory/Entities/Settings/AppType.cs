namespace Entities.Settings
{
    public record AppType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LimitCreateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
