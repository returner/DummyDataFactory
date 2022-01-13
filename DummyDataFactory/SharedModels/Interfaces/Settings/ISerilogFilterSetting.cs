namespace SharedModel.Interfaces.Configuration
{
    public interface ISerilogFilterSetting
    {
        string Filter { get; init; }
        string LogGroup { get; init; }
        int BatchPushIntervalSeconds { get; init; }
        string Region { get; init; }
    }
}
