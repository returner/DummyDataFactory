namespace SharedModel.Interfaces.Configuration
{
    public interface IAwsSetting
    {
        string AccessKey { get; init; }
        string AccessSecret { get; init; }
        string? PaymentQueueUri { get; init; }
        IS3Setting S3 { get; init; }
        IRdsSetting Rds { get; init; }
        ICognitoSetting Cognito { get; init; }
        ICognitoSetting AdminCognito { get; init; }
        IServerSetting Memcachced { get; init; }
        ISesSetting Ses { get; init; }
        ISignalRSetting SignalR { get; init; }
        IServiceBusSetting ServiceBus { get; init; }
    }
}
