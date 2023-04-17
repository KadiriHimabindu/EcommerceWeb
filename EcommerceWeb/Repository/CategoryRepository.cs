using EcommerceWeb.Data;
using EcommerceWeb.Models;
using EcommerceWeb.Repository.IRepository;
using System.Linq.Expressions;

namespace EcommerceWeb.Repository
{
    public class CategoryRepository : Repository<Category>,ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
