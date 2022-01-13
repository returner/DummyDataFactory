using SharedModel.Interfaces.Configuration;

namespace ServiceInfrastructure.Models
{
    public record SignalRSetting : ISignalRSetting
    { 
        public IServerSetting Redis { get; init; } = null!;
        public IServerSetting Queue { get; init; } = null!;
    }
}
