using azure.Model;
using Microsoft.EntityFrameworkCore;

namespace azure.Context
{
    public class productdbcontext: DbContext
    {
        public productdbcontext(DbContextOptions<productdbcontext> options): base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
