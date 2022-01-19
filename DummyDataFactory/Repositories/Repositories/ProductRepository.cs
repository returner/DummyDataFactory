using Entities.Shop;
using Repositories.Interfaces;

namespace Repositories.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task CreateProductAsync(string productName)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> ProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(int productId, string productName)
        {
            throw new NotImplementedException();
        }
    }
}
