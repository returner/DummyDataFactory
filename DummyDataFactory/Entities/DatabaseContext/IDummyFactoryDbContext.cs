using Entities.Member;
using Entities.Settings;
using Entities.Shop;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DatabaseContext
{
    public interface IDummyFactoryDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        DbSet<MemberUser> MemberUsers { get; set; }
        DbSet<AppConcept> AppConcepts { get; set; }
        DbSet<AppType> AppTypes { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserApp> UsersApp { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductCategory> ProductCategories { get; set; }
        DbSet<Cart> Carts { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderItem> OrderItems { get; set; }
    }
}
