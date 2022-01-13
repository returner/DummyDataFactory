namespace SharedModel.Interfaces.Configuration
{
    public interface ISignalRSetting
    {
        IServerSetting Redis { get; init; }
        IServerSetting Queue { get; init; }
    }
}
