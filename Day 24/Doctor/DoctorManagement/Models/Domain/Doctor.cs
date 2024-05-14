namespace DoctorManagement.Models.Domain
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
