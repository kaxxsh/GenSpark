using Microsoft.EntityFrameworkCore;
using PizzaOrdering.Models;


namespace DoctorManagement.Database
{
    public class dbConnnection : DbContext
    {
        public dbConnnection(DbContextOptions<dbConnnection> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Orders> Orders { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Users> Users { get; set; }

    }
}
