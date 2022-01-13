using SharedModel.Interfaces.Configuration;

namespace ServiceInfrastructure.Models
{
    public record CognitoSetting : ICognitoSetting
    {
        public string RegionId { get; init; } = null!;
        public string UserPoolName { get; init; } = null!;
        public string UserPoolId { get; init; } = null!;
        public string AppClientId { get; init; } = null!;
        public string TokenValidIssuer { get; init; } = null!;
        public string HostingUiUri { get; init; } = null!;
        public string GetTokenValidIssuer()
        {
            return TokenValidIssuer.Replace("-REGIONID-", RegionId).Replace("-POOLID-", UserPoolId);
        }
    }
}
