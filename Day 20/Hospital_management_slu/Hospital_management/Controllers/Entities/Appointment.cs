using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_management.Controllers.Entities
{
    public class AppointmentEntity
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("DoctorEntity")]
        public Guid DoctorId { get; set; }
        public DoctorEntity? Doctor { get; set; }

        [ForeignKey("PatientEntity")]
        public Guid PatientId { get; set; }
        public PatientEntity? Patient { get; set; }

        [Required]
        public DateTime AppointmentDateTime { get; set; }
    }
}
