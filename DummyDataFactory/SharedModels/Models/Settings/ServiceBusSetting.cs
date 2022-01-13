using SharedModel.Interfaces.Configuration;

namespace ServiceInfrastructure.Models
{
    public record ServiceBusSetting : IServiceBusSetting
    {
        public string SendEmail { get; init; } = null!;
    }
}
