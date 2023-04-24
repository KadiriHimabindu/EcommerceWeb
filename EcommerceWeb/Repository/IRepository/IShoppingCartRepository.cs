using EcommerceWeb.Models;

namespace EcommerceWeb.Repository.IRepository
{
    public interface IShoppingCartRepository: IRepository<ShoppingCart>
    {
        void Update(ShoppingCart obj);
        void add(ShoppingCart obj);
    }
}
