namespace SharedModel.Interfaces.Configuration
{
    public interface IEmailSetting
    {
        string FromAddress { get; init; }
        string SmtpEndpoint { get; init; }
        string SmtpAccessKey { get; init; }
        string SmtpSecret { get; init; }
        string SourceArn { get; init; }
    }
}