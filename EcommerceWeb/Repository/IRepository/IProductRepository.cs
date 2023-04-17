using EcommerceWeb.Models;

namespace EcommerceWeb.Repository.IRepository
{
    public interface IProductRepository: IRepository<Product>
    {
        void Update(Product obj);
       
    }
}
