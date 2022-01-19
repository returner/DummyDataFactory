using ConfigurationModel.Interfaces;

namespace ConfigurationModel.Models
{
    public record SerilogSettings : ISerilogSettings
    {
        public IEnumerable<ISerilogFilterSetting> Filters { get; init; } = null!;
    }
}
