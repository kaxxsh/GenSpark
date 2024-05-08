using System.ComponentModel.DataAnnotations;


namespace Hospital_management.Controllers.Entities
{
    public class PatientEntity
    {
        [Key]
        public Guid PatientId { get; set; }
        [Required]
        public string PatientName { get; set; } = string.Empty;
        [Required]
        public int PatientAge { get; set; } = 0;
        [Required]
        public string PatientGender { get; set; } = string.Empty;
        [Required]
        public string PatientAddress { get; set; } = string.Empty;
        [Required]
        public string PatientPhoneNumber { get; set; } = string.Empty;
        [Required]
        public string PatientEmail { get; set; } = string.Empty;
    }
}
