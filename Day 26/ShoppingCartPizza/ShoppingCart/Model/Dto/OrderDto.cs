using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Model.Dto
{
    public class OrderDto
    {
        public Guid orderId { get; set; }
        public int quantity { get; set; }
        public pizzas pizza { get; set; }
    }
}
