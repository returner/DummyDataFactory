namespace SharedModel.Interfaces.Configuration
{
    public interface IS3PathSetting
    {
        string Root { get; init; }
        string Images { get; init; }
        string Thumbnails { get; init; }
        string Videos { get; init; }
        string Sounds { get; init; }
        string Boards { get; init; }
        string Profiles { get; init; }
        string? ListThumbnail { get; init; }
        string? ViewThumbnail { get; init; }
    }
}
