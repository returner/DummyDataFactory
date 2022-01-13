using SharedModel.Interfaces.Configuration;

namespace ServiceInfrastructure.Models
{
    public record SesSetting : ISesSetting
    {
        public string IamName { get; init; } = null!;
        public string IamAccessKey { get; init; } = null!;
        public string IamSecretKey { get; init; } = null!;
        public string CredentialUser { get; init; } = null!;
        public string UserName { get; init; } = null!;
        public string Password { get; init; } = null!;
        public string SmtpServer { get; init; } = null!;
        public int Port { get; init; }
        public bool UseTls { get; init; }
        public string FromAddress { get; init; } = null!;
        public string FromName { get; init; } = null!;
    }
}
