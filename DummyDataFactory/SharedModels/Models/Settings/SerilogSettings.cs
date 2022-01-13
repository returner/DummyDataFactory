using SharedModel.Interfaces.Configuration;
using System.Collections.Generic;

namespace ServiceInfrastructure.Models
{
    public record SerilogSettings : ISerilogSettings
    {
        public IEnumerable<ISerilogFilterSetting> Filters { get; init; } = null!;
    }
}
