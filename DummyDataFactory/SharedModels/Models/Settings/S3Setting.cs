using SharedModel.Interfaces.Configuration;

namespace ServiceInfrastructure.Models
{
    public record S3Setting : IS3Setting
    {
        public string BucketName { get; init; } = null!;
        public IS3PathSetting Path { get; init; } = null!;
    }
}
