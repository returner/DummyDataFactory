using Microsoft.Extensions.DependencyInjection;
using Repositories.Interfaces;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Extensions
{
    public static class AddUserAppRepositoryExtension
    {
        public static void AddUserAppRepository(this IServiceCollection services)
        {
            services.AddTransient<IUserAppRepository, UserAppRepository>();
        }
    }
    
}
