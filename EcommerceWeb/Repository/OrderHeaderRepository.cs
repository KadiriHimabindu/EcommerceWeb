using EcommerceWeb.Data;
using EcommerceWeb.Models;
using EcommerceWeb.Repository.IRepository;
using System.Linq.Expressions;

namespace EcommerceWeb.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>,IOrderHeaderRepository
    {
        private ApplicationDbContext _db;
        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderHeader obj)
        {
            _db.OrderHeaders.Update(obj);
        }
    }
}
