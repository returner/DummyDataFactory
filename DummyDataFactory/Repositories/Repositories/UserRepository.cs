using Repositories.Interfaces;
using SharedModels.Models.Requests;
using SharedModels.Models.Responses;

namespace Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<string> GetAppNameAsync(string clientKey)
        {
            throw new NotImplementedException();
        }

        public Task<RegisterUserResponse> RegisterUserAsync(RegisterUserRequest registerUserRequest)
        {
            throw new NotImplementedException();
        }
    }
}
