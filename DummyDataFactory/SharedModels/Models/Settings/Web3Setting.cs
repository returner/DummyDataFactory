using SharedModel.Interfaces.Configuration;

namespace ServiceInfrastructure.Models
{
    public record Web3Setting: IWeb3Setting
    {
        public string Token { get; init; } = null!;
        public string Web3Url { get; init; } = null!;
        public string Owner_Address { get; init; } = null!;
        public string Contract_Private_Key { get; init; } = null!;
    }
}
