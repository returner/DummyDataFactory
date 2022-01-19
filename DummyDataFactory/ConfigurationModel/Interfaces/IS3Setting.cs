namespace ConfigurationModel.Interfaces
{
    public interface IS3Setting
    {
        string BucketName { get; init; }
        IS3PathSetting Path { get; init; }
    }
}
