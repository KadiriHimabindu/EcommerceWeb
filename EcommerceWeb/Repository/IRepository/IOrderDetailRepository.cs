using EcommerceWeb.Models;

namespace EcommerceWeb.Repository.IRepository
{
    public interface IOrderDetailRepository: IRepository<OrderDetail>
    {
        void Update(OrderDetail obj);
       
    }
}
