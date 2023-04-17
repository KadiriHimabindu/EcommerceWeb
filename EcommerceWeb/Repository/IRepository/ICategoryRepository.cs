using EcommerceWeb.Models;

namespace EcommerceWeb.Repository.IRepository
{
    public interface ICategoryRepository: IRepository<Category>
    {
        void Update(Category obj);
       
    }
}
