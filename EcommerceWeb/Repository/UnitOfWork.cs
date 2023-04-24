using EcommerceWeb.Data;
using EcommerceWeb.Repository.IRepository;

using EcommerceWeb.Models;

namespace EcommerceWeb.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        public IShoppingCartRepository ShoppingCart { get; private set; }
        public IApplicationUserRepository ApplicationUser { get; private set; }
        public IOrderHeaderRepository OrderHeader { get; private set; }
        public IOrderDetailRepository OrderDetail { get; private set; }
        public UnitOfWork(ApplicationDbContext db) 
        {
            _db = db;
            OrderDetail = new OrderDetailRepository(_db);
            OrderHeader = new OrderHeaderRepository(_db);
            ShoppingCart = new ShoppingCartRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
        public void add(OrderHeader obj)
        {
            _db.OrderHeaders.Add(obj);
            _db.SaveChanges();
        }
        public void add(OrderDetail obj)
        {
            _db.OrderDetails.Add(obj);
            _db.SaveChanges();
        }
    }
}
