
using SharedModel.Interfaces.Configuration;

namespace ServiceInfrastructure.Models
{
    public record PayCoinSetting : IPayCoinSetting
    {
        public string cp_id { get; init; } = null!;
        public string cp_pwd { get; init; } = null!;
    }
}
