namespace SharedModel.Interfaces.Configuration
{
    public interface IHenesisSetting
    {
        string Authorization { get; init; }
        string X_Henesis_Secret { get; init; }
        string APIUrl { get; init; }
        string BTC_id { get; init; }
        string BTC_Address { get; init; }
        string ETH_id { get; init; }
        string ETH_Address { get; init; }
        string KLAY_id { get; init; }
        string KLAY_Address { get; init; }
        string Passphrase { get; init; }
    }
}
