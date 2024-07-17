using azure.Model;
using azure.Repository;

namespace azure.Service
{
    public class productService
    {
        private readonly productRepository repo;

        public productService(productRepository repo)
        {
            this.repo = repo;
        }

        public async Task<IEnumerable<Product>> GetProductsasync()
        {
            return await repo.GetProducts();
        }
    }
}
