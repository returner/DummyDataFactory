namespace SharedModel.Interfaces.Configuration
{
    public interface IRdsSetting
    {
        string DatabaseName { get; init; }
        string ConnectionString { get; init; }
        string DbVersion { get; init; }
    }
}
