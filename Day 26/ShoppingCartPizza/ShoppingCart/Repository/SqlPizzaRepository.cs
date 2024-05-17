using Microsoft.EntityFrameworkCore;
using ShoppingCart.Context;
using ShoppingCart.Model;

namespace ShoppingCart.Repository
{
    public class SqlPizzaRepository : IPizzaRepository
    {
        private readonly dbconnection _context;

        public SqlPizzaRepository(dbconnection context)
        {
            _context = context;
        }

        public async Task<pizzas> createAsync(pizzas pizza)
        {
            await _context.pizzas.AddAsync(pizza);
            await _context.SaveChangesAsync();
            return pizza;
        }

        public async Task<pizzas> deleteAsync(Guid id)
        {
            var pizza = await _context.pizzas.FindAsync(id);
            if (pizza != null)
            {
                _context.pizzas.Remove(pizza);
                await _context.SaveChangesAsync();
            }
            return pizza;
        }

        public async Task<List<pizzas>> GetAllAsync()
        {
            return await _context.pizzas.ToListAsync();
        }

        public async Task<pizzas> GetByIdAsync(Guid id)
        {
            return await _context.pizzas.FirstOrDefaultAsync(x => x.pizzaId == id);
        }

        public async Task<pizzas> updateAsync(pizzas pizza)
        {
            _context.Entry(pizza).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return pizza;
        }
    }
}
