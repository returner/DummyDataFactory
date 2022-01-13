using System.Collections.Generic;

namespace SharedModel.Interfaces.Configuration
{
    public interface ISerilogSettings
    {
        IEnumerable<ISerilogFilterSetting> Filters { get; init; }
    }
}
