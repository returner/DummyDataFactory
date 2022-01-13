namespace SharedModel.Interfaces.Configuration
{
    public interface IS3Setting
    {
        string BucketName { get; init; }
        IS3PathSetting Path { get; init; }
    }
}
