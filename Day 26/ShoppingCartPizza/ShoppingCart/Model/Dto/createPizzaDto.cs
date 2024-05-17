using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Model.Dto
{
    public class createPizzaDto
    {
        public string pizzaName { get; set; }
        public int pizzaPrice { get; set; }
    }
}
