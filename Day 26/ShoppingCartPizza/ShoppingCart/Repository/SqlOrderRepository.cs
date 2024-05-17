using Microsoft.EntityFrameworkCore;
using ShoppingCart.Context;
using ShoppingCart.Model;

namespace ShoppingCart.Repository
{
    public class SqlOrderRepository : IOrderRepository
    {
        private readonly dbconnection _context;

        public SqlOrderRepository(dbconnection context)
        {
            _context = context;
        }
        public async Task<orders> createAsync(orders order)
        {
            await _context.orders.AddAsync(order);
            await _context.SaveChangesAsync();
            return order;
        }

        public async Task<orders> deleteAsync(Guid id)
        {
            var order = await _context.orders.FindAsync(id);
            if (order != null)
            {
                _context.orders.Remove(order);
                await _context.SaveChangesAsync();
            }
            return order;
        }

        public async Task<List<orders>> GetAllAsync()
        {
            return await _context.orders.Include("pizza").ToListAsync();
        }

        public async Task<orders> GetByIdAsync(Guid id)
        {
            return await _context.orders.Include("pizza").FirstOrDefaultAsync(x => x.orderId == id);
        }

        public async Task<orders> updateAsync(orders order)
        {
            _context.Entry(order).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return order;
        }
    }
}
