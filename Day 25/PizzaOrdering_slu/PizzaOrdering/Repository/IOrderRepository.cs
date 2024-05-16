using PizzaOrdering.Models;

namespace PizzaOrdering.Repository
{
    public interface IOrderRepository
    {
        Task<List<Orders>> GetAllOrders();
        Task<Orders> GetOrderById(int id);
        Task<Orders> CreateOrder(Orders order);
        Task<Orders> UpdateOrder(Orders order);
        Task<Orders> DeleteOrder(int id);

    }
}
