using DoctorManagement.Database;
using DoctorManagement.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace DoctorManagement.Repository
{
    public class SqlDoctorModel : IDoctorRepository
    {
        private readonly dbConnnection context;

        public SqlDoctorModel(dbConnnection context) {
            this.context = context;
        }

        public async Task<List<Doctor>> GetAllAsync()
        {
            return await context.Doctors.ToListAsync();
        }

        public async Task<Doctor> GetByIdAsync(Guid id)
        {
            return await context.Doctors.FindAsync(id);
        }

        public async Task<Doctor> CreateAsync(Doctor doctor)
        {
            await context.Doctors.AddAsync(doctor);
            await context.SaveChangesAsync();
            return doctor;
        }

        public async Task<Doctor> UpdateAsync(Doctor doctor)
        {
            context.Entry(doctor).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return doctor;
        }

        public async Task<Doctor> DeleteAsync(Guid id)
        {
            var data = await context.Doctors.FindAsync(id);
            if (data == null) return null;
            context.Doctors.Remove(data);
            await context.SaveChangesAsync();
            return data;
        }

        

        

        
    }
}
