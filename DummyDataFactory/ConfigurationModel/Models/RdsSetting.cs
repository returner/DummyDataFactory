using ConfigurationModel.Interfaces;

namespace ConfigurationModel.Models
{
    public record RdsSetting : IRdsSetting
    {
        public string ConnectionString { get; init; } = null!;
        public string DbVersion { get; init; } = null!;
    }
}
