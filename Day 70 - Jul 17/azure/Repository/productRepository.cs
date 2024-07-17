using azure.Context;
using azure.Model;
using Microsoft.EntityFrameworkCore;

namespace azure.Repository
{
    public class productRepository
    {
        private readonly productdbcontext db;

        public productRepository(productdbcontext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await db.Products.ToListAsync();
        }
    }
}
