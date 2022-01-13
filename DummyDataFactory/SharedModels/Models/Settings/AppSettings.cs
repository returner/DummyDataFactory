using SharedModel.Interfaces.Configuration;
using System.Collections.Generic;

namespace ServiceInfrastructure.Models
{
    public record AppSettings : IAppSettings
    {
        public string Environment { get; init; } = null!;
        public IAwsSetting AWS { get; init; } = null!;
        public IWeb3Setting Web3 { get; init; } = null!;
        public IEnumerable<string> CorsOrigins { get; init; } = null!;
        public IEnumerable<string> CorsAdminOrigins { get; init; } = null!;
        public IHenesisSetting Henesis { get; init; } = null!;
        public ISwaggerSetting Swagger { get; init; } = null!;
        public ISwaggerSetting AdminSwagger { get; init; } = null!;
        public IAdminSetting Admin { get; init; } = null!;
        public string PaypalUrl { get; init; } = null!;
        public string PaypalPDTToken { get; init; } = null!;
        public IPayCoinSetting PayCoin { get; init; } = null!;
    }
}
