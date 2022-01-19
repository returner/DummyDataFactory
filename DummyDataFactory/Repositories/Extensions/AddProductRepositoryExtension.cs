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
    public static class AddProductRepositoryExtension
    {
        public static void AddProductRepository(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
