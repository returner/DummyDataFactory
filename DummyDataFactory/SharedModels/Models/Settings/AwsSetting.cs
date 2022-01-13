using SharedModel.Interfaces.Configuration;

namespace ServiceInfrastructure.Models
{
    public record AwsSetting : IAwsSetting
    {
        public IRdsSetting Rds { get; init; } = null!;
        public ICognitoSetting Cognito { get; init; } = null!;
        public ICognitoSetting AdminCognito { get; init; } = null!;
        public IS3Setting S3 { get; init; } = null!;
        public string AccessKey { get; init; } = null!;
        public string AccessSecret { get; init; } = null!;
        public IServerSetting Memcachced { get; init; } = null!;
        public ISesSetting Ses { get; init; } = null!;
        public ISignalRSetting SignalR { get; init; } = null!;
        public string? PaymentQueueUri { get; init; }
        public IServiceBusSetting ServiceBus { get; init; } = null!;
    }
}
