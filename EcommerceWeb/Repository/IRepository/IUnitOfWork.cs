using EcommerceWeb.Models;

namespace EcommerceWeb.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category{ get; }
        IProductRepository Product { get; }
        IShoppingCartRepository ShoppingCart { get; }
        IApplicationUserRepository ApplicationUser { get; }
        IOrderDetailRepository OrderDetail { get; }
        IOrderHeaderRepository OrderHeader { get; }
        void Save();
        void add(OrderDetail obj);
        void add(OrderHeader obj);
    }
}
