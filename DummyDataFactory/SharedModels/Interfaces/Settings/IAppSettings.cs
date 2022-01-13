using System.Collections.Generic;

namespace SharedModel.Interfaces.Configuration
{
    public interface IAppSettings
    {
        string Environment { get; init; }
        IAdminSetting Admin { get; init; }
        ISwaggerSetting Swagger { get; init; }
        ISwaggerSetting AdminSwagger { get; init; }
        IEnumerable<string> CorsOrigins { get; init; }
        IEnumerable<string> CorsAdminOrigins { get; init; }
        IWeb3Setting Web3 { get; init; }
        IHenesisSetting Henesis { get; init; }
        IAwsSetting AWS { get; init; }
        IPayCoinSetting PayCoin { get; init; }
        string PaypalUrl { get; init; }
        string PaypalPDTToken { get; init; }
    }
}
