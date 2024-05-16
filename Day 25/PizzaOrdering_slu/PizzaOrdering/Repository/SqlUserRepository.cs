using DoctorManagement.Database;
using Microsoft.EntityFrameworkCore;
using PizzaOrdering.Models;

namespace PizzaOrdering.Repository
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly dbConnnection context;

        public SqlUserRepository(dbConnnection context)
        {
            this.context = context;
        }
        public async Task<Users> CreateUser(Users user)
        {
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
            return user;
        }

        public async Task<Users> DeleteUser(int id)
        {
            var data = await context.Users.FindAsync(id);
            if (data == null) return null;
            context.Users.Remove(data);
            await context.SaveChangesAsync();
            return data;
        }

        public async Task<List<Users>> GetAllUser()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<Users> GetUserById(int id)
        {
            return await context.Users.FindAsync(id);
        }

        public async Task<Users> UpdateUser(Users user)
        {
            context.Entry(user).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return user;
        }
    }
}
