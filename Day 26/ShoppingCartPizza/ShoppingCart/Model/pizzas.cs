using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Model
{
    public class pizzas
    {
        [Key]
        public Guid pizzaId { get; set; }
        [Required]
        public string pizzaName { get; set; }
        [Required]
        public int pizzaPrice { get; set; }
    }
}
