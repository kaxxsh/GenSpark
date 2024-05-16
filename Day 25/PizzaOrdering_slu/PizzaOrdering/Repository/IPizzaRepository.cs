using PizzaOrdering.Models;

namespace PizzaOrdering.Repository
{
    public interface IPizzaRepository
    {
        Task<List<Pizza>> GetAllAsync();
        Task<Pizza> GetByIdAsync(int id);
        Task<Pizza> CreateAsync(Pizza pizza);
        Task<Pizza> UpdateAsync(Pizza pizza);
        Task<Pizza> DeleteAsync(int id);

    }
}
