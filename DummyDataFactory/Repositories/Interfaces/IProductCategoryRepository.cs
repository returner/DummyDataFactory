using Entities.Shop;

namespace Repositories.Interfaces
{
    public interface IProductCategoryRepository
    {
        Task CreateProductCategoryAsync();
        Task DeleteProductCategoryAsync();
        Task UpdateProductCategoryAsync();
        Task<IEnumerable<ProductCategory>> ProductCategoriesAsync();
    }
}
