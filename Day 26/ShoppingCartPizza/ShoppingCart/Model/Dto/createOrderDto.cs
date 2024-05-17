using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Model.Dto
{
    public class createOrderDto
    {
        public Guid pizzaId { get; set; }
        public int quantity { get; set; }
    }
}
