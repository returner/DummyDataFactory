namespace SharedModel.Interfaces.Configuration
{
    public interface ISesSetting
    {
        public string CredentialUser { get; init; }
        public string UserName { get; init; }
        public string Password { get; init; }
        public string SmtpServer { get; init; }
        public int Port { get; init; }
        public bool UseTls { get; init; }
        public string FromAddress { get; init; }
        public string FromName { get; init; }
    }
}
