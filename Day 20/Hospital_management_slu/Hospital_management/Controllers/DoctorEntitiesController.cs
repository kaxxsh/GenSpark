using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hospital_management.Controllers.Entities;
using Hospital_management.Data;

namespace Hospital_management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorEntitiesController : ControllerBase
    {
        private readonly DataContext _context;

        public DoctorEntitiesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/DoctorEntities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DoctorEntity>>> GetDoctors()
        {
            return await _context.Doctors.ToListAsync();
        }

        // GET: api/DoctorEntities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DoctorEntity>> GetDoctorEntity(Guid id)
        {
            var doctorEntity = await _context.Doctors.FindAsync(id);

            if (doctorEntity == null)
            {
                return NotFound();
            }

            return doctorEntity;
        }

        // PATCH: api/DoctorEntities/5
        [HttpPatch("{id}")]
        public async Task<IActionResult> PutDoctorEntity(Guid id, DoctorEntity doctorEntity)
        {
            try
            {
                var data = await _context.Doctors.FindAsync(id);
                data.Name = doctorEntity.Name;
                data.Specialization = doctorEntity.Specialization;
                data.PhoneNumber = doctorEntity.PhoneNumber;
                data.Email = doctorEntity.Email;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DoctorEntityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/DoctorEntities
        [HttpPost]
        public async Task<ActionResult<DoctorEntity>> PostDoctorEntity(DoctorEntity doctorEntity)
        {
            _context.Doctors.Add(doctorEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDoctorEntity", new { id = doctorEntity.DoctorId }, doctorEntity);
        }

        // DELETE: api/DoctorEntities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctorEntity(Guid id)
        {
            var doctorEntity = await _context.Doctors.FindAsync(id);
            if (doctorEntity == null)
            {
                return NotFound();
            }

            _context.Doctors.Remove(doctorEntity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DoctorEntityExists(Guid id)
        {
            return _context.Doctors.Any(e => e.DoctorId == id);
        }
    }
}
