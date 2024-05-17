using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Model.Dto
{
    public class PizzaDto
    {
        public Guid pizzaId { get; set; }

        [Required]
        public string pizzaName { get; set; }
        [Required]
        public int pizzaPrice { get; set; }
    }
}
