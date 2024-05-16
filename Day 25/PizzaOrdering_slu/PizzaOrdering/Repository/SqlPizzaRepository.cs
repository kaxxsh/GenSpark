using DoctorManagement.Database;
using Microsoft.EntityFrameworkCore;
using PizzaOrdering.Models;
using System.Numerics;

namespace PizzaOrdering.Repository
{
    public class SqlPizzaRepository : IPizzaRepository
    {
        private readonly dbConnnection context;

        public SqlPizzaRepository(dbConnnection context) {
            this.context = context;
        }
        public async Task<Pizza> CreateAsync(Pizza pizza)
        {
            await context.Pizzas.AddAsync(pizza);
            await context.SaveChangesAsync();
            return pizza;
        }

        public async Task<Pizza> DeleteAsync(int id)
        {
            var data = await context.Pizzas.FindAsync(id);
            if (data == null) return null;
            context.Pizzas.Remove(data);
            await context.SaveChangesAsync();
            return data;
        }

        public async Task<List<Pizza>> GetAllAsync()
        {
            return await context.Pizzas.ToListAsync();
        }

        public async Task<Pizza> GetByIdAsync(int id)
        {
            return await context.Pizzas.FindAsync(id);
        }

        public async Task<Pizza> UpdateAsync(Pizza pizza)
        {
            context.Entry(pizza).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return pizza;
        }
    }
}
