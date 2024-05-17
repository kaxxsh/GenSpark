using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Model
{
    public class orders
    {
        [Key]
        public Guid orderId { get; set; }
        [Required]
        public Guid pizzaId { get; set; }
        [Required]
        public int quantity { get; set; }
        
        public pizzas pizza { get; set; }
    }
}
