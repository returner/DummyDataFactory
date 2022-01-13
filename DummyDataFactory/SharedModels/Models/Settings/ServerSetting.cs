using SharedModel.Interfaces.Configuration;

namespace ServiceInfrastructure.Models
{
    public record ServerSetting : IServerSetting
    {
        public string? Name { get; init; }
        public string Address { get; init; } = null!;
        public int Port { get; init; }
    }
}
