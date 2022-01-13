using SharedModel.Interfaces.Configuration;

namespace ServiceInfrastructure.Models
{
    public class HenesisSetting : IHenesisSetting
    {
        public string Authorization { get; init; } = null!;
        public string X_Henesis_Secret { get; init; } = null!;
        public string APIUrl { get; init; } = null!;
        public string BTC_id { get; init; } = null!;
        public string BTC_Address { get; init; } = null!;
        public string ETH_id { get; init; } = null!;
        public string ETH_Address { get; init; } = null!;
        public string KLAY_id { get; init; } = null!;
        public string KLAY_Address { get; init; } = null!;
        public string Passphrase { get; init; } = null!;
    }
}
