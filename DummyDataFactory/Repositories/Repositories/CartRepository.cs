using Entities.Shop;
using Repositories.Interfaces;

namespace Repositories.Repositories
{
    public class CartRepository : ICartRepository
    {
        public Task AddProductToCartAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> CartItems()
        {
            throw new NotImplementedException();
        }

        public Task RemoveProductFromCartAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrderFromCartAsync(IEnumerable<int> productIds)
        {
            throw new NotImplementedException();
        }
    }
}
