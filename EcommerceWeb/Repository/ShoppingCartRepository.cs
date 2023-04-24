using EcommerceWeb.Data;
using EcommerceWeb.Models;
using EcommerceWeb.Repository.IRepository;
using System.Linq.Expressions;

namespace EcommerceWeb.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>,IShoppingCartRepository
    {
        private ApplicationDbContext _db;
        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
        public void add(ShoppingCart obj)
        {
            _db.ShoppingCarts.Add(obj);
            _db.SaveChanges();
        }
    }
}
