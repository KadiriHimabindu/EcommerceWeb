using EcommerceWeb.Models;

namespace EcommerceWeb.Repository.IRepository
{
    public interface IOrderHeaderRepository: IRepository<OrderHeader>
    {
        void Update(OrderHeader obj);
       
    }
}
