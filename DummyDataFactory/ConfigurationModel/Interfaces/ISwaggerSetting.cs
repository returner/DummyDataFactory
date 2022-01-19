namespace ConfigurationModel.Interfaces
{
    public interface ISwaggerSetting
    {
        string Title { get; init; }
        string Version { get; init; }
        string Description { get; init; }
        string Link { get; init; }
    }
}
