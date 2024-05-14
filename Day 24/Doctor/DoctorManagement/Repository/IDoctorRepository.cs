using DoctorManagement.Models.Domain;

namespace DoctorManagement.Repository
{
    public interface IDoctorRepository
    {
        Task<List<Doctor>> GetAllAsync();
        Task<Doctor> GetByIdAsync(Guid id);
        Task<Doctor> CreateAsync(Doctor doctor);
        Task<Doctor> UpdateAsync(Doctor doctor);
        Task<Doctor> DeleteAsync(Guid id);

    }
}
