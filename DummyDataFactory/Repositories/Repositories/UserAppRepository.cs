using Entities.Settings;
using Repositories.Interfaces;

namespace Repositories.Repositories
{
    public class UserAppRepository : IUserAppRepository
    {
        public Task<string> CreateUserAppAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<UserApp> GetUserAppAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExpiredUserAppAsync(int userAppId)
        {
            throw new NotImplementedException();
        }

        public Task SetInactiveUserAppAsync(int userAppId)
        {
            throw new NotImplementedException();
        }
    }
}
