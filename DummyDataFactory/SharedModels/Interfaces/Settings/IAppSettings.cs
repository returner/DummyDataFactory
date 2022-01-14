using System.Collections.Generic;

namespace SharedModel.Interfaces.Configuration
{
    public interface IAppSettings
    {
        string Environment { get; init; }
        ISwaggerSetting Swagger { get; init; }
        ISwaggerSetting AdminSwagger { get; init; }
        IEnumerable<string> CorsOrigins { get; init; }
        IAwsSetting AWS { get; init; }
    }
}
