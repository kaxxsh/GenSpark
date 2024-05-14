using DoctorManagement.Models.Domain;
using Microsoft.EntityFrameworkCore;


namespace DoctorManagement.Database
{
    public class dbConnnection:DbContext
    {
        public dbConnnection(DbContextOptions<dbConnnection> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Doctor> Doctors { get; set; }
    }
}
