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
    public static class AddProductCategoryRepositoryExtension
    {
        public static void AddProductCategoryRepository(this IServiceCollection services)
        {
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
        }
    }
}
