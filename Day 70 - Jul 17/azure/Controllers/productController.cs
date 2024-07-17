using azure.Model;
using azure.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace azure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productController : ControllerBase
    {
        private readonly productService service;

        public productController(productService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await service.GetProductsasync();
        }
    }
}
