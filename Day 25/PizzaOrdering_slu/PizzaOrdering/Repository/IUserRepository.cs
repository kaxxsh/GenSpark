using PizzaOrdering.Models;

namespace PizzaOrdering.Repository
{
    public interface IUserRepository
    {
        Task<List<Users>> GetAllUser();
        Task<Users> GetUserById(int id);
        Task<Users> CreateUser(Users user);
        Task<Users> UpdateUser(Users user);
        Task<Users> DeleteUser(int id);
    }
}
