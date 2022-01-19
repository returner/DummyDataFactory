namespace ConfigurationModel.Interfaces
{
    public interface IRdsSetting
    {
        string ConnectionString { get; init; }
        string DbVersion { get; init; }
    }
}
