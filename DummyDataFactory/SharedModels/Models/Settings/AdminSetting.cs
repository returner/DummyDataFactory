using SharedModel.Interfaces.Configuration;

namespace ServiceInfrastructure.Models
{
    public record AdminSetting : IAdminSetting
    {
        public string BaseAddress { get; init; } = null!;
    }
}
