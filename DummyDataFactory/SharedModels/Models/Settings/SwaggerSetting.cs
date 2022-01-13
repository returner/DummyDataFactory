using SharedModel.Interfaces.Configuration;

namespace ServiceInfrastructure.Models
{
    public record SwaggerSetting: ISwaggerSetting
    {
        public string Title { get; init; } = null!;
        public string Version { get; init; } = null!;
        public string Description { get; init; } = null!;
        public string Link { get; init; } = null!;
    }
}
