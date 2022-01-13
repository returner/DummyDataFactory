using SharedModel.Interfaces.Configuration;

namespace ServiceInfrastructure.Models
{
    public record SerilogFilterSetting : ISerilogFilterSetting
    {
        public string Filter { get; init; } = null!;
        public string LogGroup { get; init; } = null!;
        public int BatchPushIntervalSeconds { get; init; }
        public string Region { get; init; } = null!;
    }
}
