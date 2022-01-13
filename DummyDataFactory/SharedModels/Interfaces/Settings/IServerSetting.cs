namespace SharedModel.Interfaces.Configuration
{
    public interface IServerSetting
    {
        string? Name { get; init; }
        string Address { get; init; }
        int Port { get; init; }
    }
}
