using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Model;
using ShoppingCart.Model.Dto;
using ShoppingCart.Repository;

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class orderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public orderController(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var order = await _orderRepository.GetAllAsync();
            return Ok(_mapper.Map<List<OrderDto>>(order));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(Guid id)
        {
            var order = await _orderRepository.GetByIdAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<OrderDto>(order));
        }

        [HttpPost]
        public async Task<ActionResult<orders>> Post(createOrderDto order)
        {
            var orderModel = _mapper.Map<orders>(order);
            await _orderRepository.createAsync(orderModel);
            var orderDto = _mapper.Map<OrderDto>(orderModel);
            return CreatedAtAction(nameof(Get), new { id = orderDto.orderId }, orderDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(Guid id, updateOrderDto order)
        {
            var orderModelFromRepo = await _orderRepository.GetByIdAsync(id);
            if (orderModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(order, orderModelFromRepo); 
            await _orderRepository.updateAsync(orderModelFromRepo);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var orderModelFromRepo = await _orderRepository.GetByIdAsync(id);
            if (orderModelFromRepo == null)
            {
                return NotFound();
            }
            await _orderRepository.deleteAsync(id);
            return NoContent();
        }
    }
}
