namespace DoctorManagement.Models.Dto
{
    public class GetDoctorDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
