using Entities.Shop;

namespace Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task CreateProductAsync(string productName);
        Task<IEnumerable<Product>> ProductsAsync();
        Task DeleteProductAsync(int productId);
        Task UpdateProductAsync(int productId, string productName);
    }
}
