using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hospital_management.Controllers.Entities;
using Hospital_management.Data;

namespace Hospital_management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentEntitiesController : ControllerBase
    {
        private readonly DataContext _context;

        public AppointmentEntitiesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/AppointmentEntities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppointmentEntity>>> GetAppointments()
        {
            return await _context.Appointments
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .ToListAsync();
        }

        // GET: api/AppointmentEntities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AppointmentEntity>> GetAppointmentEntity(Guid id)
        {
            var appointmentEntity = await _context.Appointments
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (appointmentEntity == null)
            {
                return NotFound();
            }

            return appointmentEntity;
        }

        // PUT: api/AppointmentEntities/5
        [HttpPatch("{id}")]
        public async Task<IActionResult> PutAppointmentEntity(Guid id, AppointmentEntity appointmentEntity)
        {
            try
            {
                var data = await _context.Appointments.FindAsync(id);
                if (data == null)
                {
                    return NotFound();
                }
                data.DoctorId = appointmentEntity.DoctorId;
              
                data.PatientId = appointmentEntity.PatientId;
               
                data.AppointmentDateTime = appointmentEntity.AppointmentDateTime;

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppointmentEntityExists(id))
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

        // POST: api/AppointmentEntities
        [HttpPost]
        public async Task<ActionResult<AppointmentEntity>> PostAppointmentEntity(AppointmentEntity appointmentEntity)
        {
            _context.Appointments.Add(appointmentEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppointmentEntity", new { id = appointmentEntity.Id }, appointmentEntity);
        }

        // DELETE: api/AppointmentEntities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppointmentEntity(Guid id)
        {
            var appointmentEntity = await _context.Appointments.FindAsync(id);
            if (appointmentEntity == null)
            {
                return NotFound();
            }

            _context.Appointments.Remove(appointmentEntity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppointmentEntityExists(Guid id)
        {
            return _context.Appointments.Any(e => e.Id == id);
        }
    }
}
