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
    public static class AddCartRepositoryExtension
    {
        public static void AddCartRepository(this IServiceCollection services)
        {
            services.AddTransient<ICartRepository, CartRepository>();
        }
    }
}
