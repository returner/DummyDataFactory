using SharedModels.Models.Requests;
using SharedModels.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<RegisterUserResponse> RegisterUserAsync(RegisterUserRequest registerUserRequest);
        Task<string> GetAppNameAsync(string clientKey);
    }
}
