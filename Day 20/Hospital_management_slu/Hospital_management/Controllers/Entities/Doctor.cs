using System.ComponentModel.DataAnnotations;
namespace Hospital_management.Controllers.Entities
{
    public class DoctorEntity
    {
        [Key]
        public Guid DoctorId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Specialization { get; set; } = string.Empty;
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
    }
}
