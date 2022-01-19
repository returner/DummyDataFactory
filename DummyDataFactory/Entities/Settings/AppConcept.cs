namespace Entities.Settings
{
    public record AppConcept
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsUse { get; set; }
        public DateTime CreateDateTime { get; set; }
    }

}
