namespace ConfigurationModel.Interfaces
{
    public interface ISerilogSettings
    {
        IEnumerable<ISerilogFilterSetting> Filters { get; init; }
    }
}
