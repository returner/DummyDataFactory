using SharedModel.Interfaces.Configuration;
using System.Collections.Generic;

namespace ServiceInfrastructure.Models
{
    public record AppSettings : IAppSettings
    {
        public string Environment { get; init; } = null!;
        public IAwsSetting AWS { get; init; } = null!;
        public IEnumerable<string> CorsOrigins { get; init; } = null!;
        public ISwaggerSetting Swagger { get; init; } = null!;
        public string Database { get; init; } = null!;
    }
}
