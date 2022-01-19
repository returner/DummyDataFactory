using ConfigurationModel.Interfaces;

namespace ConfigurationModel.Models
{
    public record AwsSetting : IAwsSetting
    {
        public IRdsSetting Rds { get; init; } = null!;
        public ICognitoSetting Cognito { get; init; } = null!;
        public ICognitoSetting AdminCognito { get; init; } = null!;
        public IS3Setting S3 { get; init; } = null!;
    }
}
