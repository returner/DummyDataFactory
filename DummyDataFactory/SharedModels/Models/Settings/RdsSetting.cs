using SharedModel.Interfaces.Configuration;

namespace ServiceInfrastructure.Models
{
    public record RdsSetting : IRdsSetting
    {
        public string DatabaseName { get; init; } = null!;
        public string ConnectionString { get; init; } = null!;
        public string DbVersion { get; init; } = null!;
    }
}
