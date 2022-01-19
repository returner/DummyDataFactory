using Entities.Member;
using Entities.Settings;
using Entities.Shop;
using Microsoft.EntityFrameworkCore;

namespace Entities.DatabaseContext
{
    public class DummyFactoryDbContext : DbContext, IDummyFactoryDbContext
    {
        public DummyFactoryDbContext()
        {

        }
        public DummyFactoryDbContext(DbContextOptions<DummyFactoryDbContext> options)
            : base(options)
        {
        }

        public DbSet<MemberUser> MemberUsers { get; set; } = null!;
        public DbSet<AppConcept> AppConcepts { get; set; } = null!;
        public DbSet<AppType> AppTypes { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<UserApp> UsersApp { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ProductCategory> ProductCategories { get; set; } = null!;
        public DbSet<Cart> Carts { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderItem> OrderItems { get; set; } = null!;
    }
}
