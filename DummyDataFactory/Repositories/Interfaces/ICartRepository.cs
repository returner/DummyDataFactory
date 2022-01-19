using Entities.Shop;

namespace Repositories.Interfaces
{
    public interface ICartRepository
    {
        Task AddProductToCartAsync(int productId);
        Task RemoveProductFromCartAsync(int productId);
        Task UpdateOrderFromCartAsync(IEnumerable<int> productIds);
        Task<IEnumerable<Product>> CartItems();
    }
}
