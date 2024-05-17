using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.Context
{
    public class dbconnection : DbContext
    {
        public dbconnection(DbContextOptions<dbconnection> options) : base(options)
        {
            
        }

        public DbSet<Model.orders> orders { get; set; }
        public DbSet<Model.pizzas> pizzas { get; set; }
    }
}
