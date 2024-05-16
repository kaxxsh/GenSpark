namespace PizzaOrdering.Models.Dto
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public Users? Users { get; set; }
        public Pizza? Pizza { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
    }
}
