using EcommerceWeb.Data;
using EcommerceWeb.Models;
using EcommerceWeb.Repository.IRepository;
using System.Linq.Expressions;

namespace EcommerceWeb.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>,IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
