namespace SharedModel.Interfaces.Configuration
{
    public interface IAwsSetting
    {
        IS3Setting S3 { get; init; }
        IRdsSetting Rds { get; init; }
        ICognitoSetting Cognito { get; init; }
    }
}
