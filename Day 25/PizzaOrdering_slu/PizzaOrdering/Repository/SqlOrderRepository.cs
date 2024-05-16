using DoctorManagement.Database;
using Microsoft.EntityFrameworkCore;
using PizzaOrdering.Models;
using System.Numerics;

namespace PizzaOrdering.Repository
{
    public class SqlOrderRepository : IOrderRepository
    {
        private readonly dbConnnection context;

        public SqlOrderRepository(dbConnnection context)
        {
            this.context = context;
        }
        public async Task<Orders> CreateOrder(Orders order)
        {
            await context.Orders.AddAsync(order);
            await context.SaveChangesAsync();
            return order;
        }

        public async Task<Orders> DeleteOrder(int id)
        {
            var data = await context.Orders.FindAsync(id);
            if (data == null) return null;
            context.Orders.Remove(data);
            await context.SaveChangesAsync();
            return data;
        }

        public async Task<List<Orders>> GetAllOrders()
        {
            return await context.Orders.ToListAsync();
        }

        public async Task<Orders> GetOrderById(int id)
        {
            return await context.Orders.FindAsync(id);
        }

        public async Task<Orders> UpdateOrder(Orders order)
        {
            context.Entry(order).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return order;
        }
    }
}
