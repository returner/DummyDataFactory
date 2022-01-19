using Entities.DatabaseContext;
using Microsoft.Extensions.DependencyInjection;

namespace Entities.Extension
{
    public static class AddDummyFactoryDbContextExtension
    {
        public static void AddDummyFactoryDbContext(this IServiceCollection services)
        {
            services.AddSingleton<IDummyFactoryDbContext, DummyFactoryDbContext>();
        }
    }
}
