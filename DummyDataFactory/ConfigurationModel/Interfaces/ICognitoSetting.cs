namespace ConfigurationModel.Interfaces
{
    public interface ICognitoSetting
    {
        string RegionId { get; init; }
        string UserPoolName { get; init; }
        string UserPoolId { get; init; }
        string AppClientId { get; init; }
        string TokenValidIssuer { get; init; }
        string HostingUiUri { get; init; }
        string GetTokenValidIssuer();
    }
}
