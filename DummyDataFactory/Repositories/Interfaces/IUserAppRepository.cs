using Entities.Settings;

namespace Repositories.Interfaces
{
    public interface IUserAppRepository
    {
        Task<string> CreateUserAppAsync(User user);
        Task<UserApp> GetUserAppAsync(User user);
        Task<bool> IsExpiredUserAppAsync(int userAppId);
        Task SetInactiveUserAppAsync(int userAppId);
    }
}
