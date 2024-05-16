using System.ComponentModel.DataAnnotations;

namespace PizzaOrdering.Models
{
    public class Users
    {
        public Guid UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
