using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaOrdering.Models;
using PizzaOrdering.Repository;

namespace PizzaOrdering.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaRepository _pizzaRepository;

        public PizzaController(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Pizza>>> GetAllPizzas()
        {
            return await _pizzaRepository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pizza>> GetPizzaById(int id)
        {
            return await _pizzaRepository.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<Pizza>> CreatePizza(Pizza pizza)
        {
            return await _pizzaRepository.CreateAsync(pizza);
        }

        [HttpPut]
        public async Task<ActionResult<Pizza>> UpdatePizza(Pizza pizza)
        {
            return await _pizzaRepository.UpdateAsync(pizza);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Pizza>> DeletePizza(int id)
        {
            return await _pizzaRepository.DeleteAsync(id);
        }
    }
}
