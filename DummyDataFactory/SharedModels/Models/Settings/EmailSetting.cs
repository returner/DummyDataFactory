using SharedModel.Interfaces.Configuration;

namespace ServiceInfrastructure.Models
{
    public class EmailSetting : IEmailSetting
    {
        public string FromAddress { get; init; } = null!;
        public string SmtpEndpoint { get; init; } = null!;
        public string SmtpAccessKey { get; init; } = null!;
        public string SmtpSecret { get; init; } = null!;
        public string SourceArn { get; init; } = null!;
    }
}