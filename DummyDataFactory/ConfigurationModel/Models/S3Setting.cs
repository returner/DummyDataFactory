using ConfigurationModel.Interfaces;

namespace ConfigurationModel.Models
{
    public record S3Setting : IS3Setting
    {
        public string BucketName { get; init; } = null!;
        public IS3PathSetting Path { get; init; } = null!;
    }
}
