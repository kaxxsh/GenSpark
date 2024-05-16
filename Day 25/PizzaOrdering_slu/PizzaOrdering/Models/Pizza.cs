namespace PizzaOrdering.Models
{
    public class Pizza
    {
        public Guid PizzaID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
