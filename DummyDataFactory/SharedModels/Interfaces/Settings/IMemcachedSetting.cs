namespace SharedModel.Interfaces.Configuration
{
    public interface IMemcachedSetting
    {
        string Address { get; init; }
        int Port { get; init; }
    }
}
