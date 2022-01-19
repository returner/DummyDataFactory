using SharedModels.Models.Requests;
using SharedModels.Models.Responses;

namespace Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<RegisterUserResponse> RegisterUserAsync(RegisterUserRequest registerUserRequest);
        Task<string> GetAppNameAsync(string clientKey);
    }
}
