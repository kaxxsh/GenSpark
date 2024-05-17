using ShoppingCart.Model;

namespace ShoppingCart.Repository
{
    public interface IOrderRepository
    {
        Task<List<orders>> GetAllAsync();
        Task<orders> GetByIdAsync(Guid id);
        Task<orders> createAsync(orders order);
        Task<orders> updateAsync(orders order);
        Task<orders> deleteAsync(Guid id);

    }
}
