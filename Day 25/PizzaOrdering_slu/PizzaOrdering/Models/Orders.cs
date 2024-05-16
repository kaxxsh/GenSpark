namespace PizzaOrdering.Models
{
    public class Orders
    {
        public Guid Id { get; set; }
        public Guid UserID { get; set; }
        public Guid PizzaID { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }


        public Users? Users { get; set; }
        public Pizza? Pizza { get; set; }
    }
}
