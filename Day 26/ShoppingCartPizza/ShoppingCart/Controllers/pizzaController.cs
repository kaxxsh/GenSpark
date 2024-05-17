using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Model;
using ShoppingCart.Model.Dto;
using ShoppingCart.Repository;

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class pizzaController : ControllerBase
    {
        private readonly IPizzaRepository _pizzaRepository;
        private readonly IMapper _mapper;

        public pizzaController(IPizzaRepository pizzaRepository, IMapper mapper)
        {
            _pizzaRepository = pizzaRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<pizzas>>> Get()
        {
            var pizzas = await _pizzaRepository.GetAllAsync();
            var pizzaDtos = _mapper.Map<List<PizzaDto>>(pizzas);
            return Ok(pizzaDtos);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<pizzas>> Get(Guid id)
        {
            var pizza = await _pizzaRepository.GetByIdAsync(id);
            if (pizza == null)
            {
                return NotFound();
            }
            var pizzaDto = _mapper.Map<PizzaDto>(pizza);
            return Ok(pizzaDto);
        }

        [HttpPost]
        public async Task<ActionResult<pizzas>> Post(createPizzaDto pizza)
        {
            var pizzaModel = _mapper.Map<pizzas>(pizza);
            await _pizzaRepository.createAsync(pizzaModel);
            var pizzaDto = _mapper.Map<PizzaDto>(pizzaModel);
            return CreatedAtAction(nameof(Get), new { id = pizzaDto.pizzaId }, pizzaDto);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult> Put(Guid id, updatePizzaDto pizza)
        {
            var pizzaModelFromRepo = await _pizzaRepository.GetByIdAsync(id);
            if (pizzaModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(pizza, pizzaModelFromRepo);
            await _pizzaRepository.updateAsync(pizzaModelFromRepo);
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var pizzaModelFromRepo = await _pizzaRepository.GetByIdAsync(id);
            if (pizzaModelFromRepo == null)
            {
                return NotFound();
            }
            await _pizzaRepository.deleteAsync(id);
            return NoContent();
        }
    }
}
