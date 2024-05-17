using ShoppingCart.Model;

namespace ShoppingCart.Repository
{
    public interface IPizzaRepository
    {
        Task<List<pizzas>> GetAllAsync();

        Task<pizzas> GetByIdAsync(Guid id);
        Task<pizzas> createAsync(pizzas pizza);
        Task<pizzas> updateAsync(pizzas pizza);
        Task<pizzas> deleteAsync(Guid id);

    }
}
