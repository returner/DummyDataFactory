using System.Collections.Generic;

namespace ConfigurationModel.Interfaces
{
    public interface IAppSettings
    {
        string Environment { get; init; }
        ISwaggerSetting Swagger { get; init; }
        IEnumerable<string> CorsOrigins { get; init; }
        IAwsSetting AWS { get; init; }
        string Database { get; init; }
    }
}
