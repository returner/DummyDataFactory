
using ConfigurationModel.Interfaces;

namespace ConfigurationModel.Models
{
    public record S3PathSetting : IS3PathSetting
    {
        public string Root { get; init; } = null!;
        public string Images { get; init; } = null!;
        public string Thumbnails { get; init; } = null!;
        public string? ListThumbnail { get; init; } = null!;
        public string? ViewThumbnail { get; init; } = null!;
        public string Videos { get; init; } = null!;
        public string Sounds { get; init; } = null!;
        public string Boards { get; init; } = null!;
        public string Profiles { get; init; } = null!;
    }
}
