namespace SharedModel.Interfaces.Configuration
{
    public interface IWeb3Setting
    {
        string Token { get; init; }
        string Web3Url { get; init; }
        string Owner_Address { get; init; }
        string Contract_Private_Key { get; init; }
    }
}
