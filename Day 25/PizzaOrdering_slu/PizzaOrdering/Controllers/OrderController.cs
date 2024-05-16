using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaOrdering.Models;
using PizzaOrdering.Repository;

namespace PizzaOrdering.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository, IPizzaRepository pizzaRepository, IUserRepository userRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Orders>>> GetAllOrders()
        {
            return await _orderRepository.GetAllOrders();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Orders>> GetOrderById(int id)
        {
            return await _orderRepository.GetOrderById(id);
        }

        [HttpPost]
        public async Task<ActionResult<Orders>> CreateOrder(Orders order)
        {
            return await _orderRepository.CreateOrder(order);
        }

        [HttpPut]
        public async Task<ActionResult<Orders>> UpdateOrder(Orders order)
        {
            return await _orderRepository.UpdateOrder(order);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Orders>> DeleteOrder(int id)
        {
            return await _orderRepository.DeleteOrder(id);
        }

    }
}
