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
    public class PatientEntitiesController : ControllerBase
    {
        private readonly DataContext _context;

        public PatientEntitiesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/PatientEntities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PatientEntity>>> GetPatients()
        {
            return await _context.Patients.ToListAsync();
        }

        // GET: api/PatientEntities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PatientEntity>> GetPatientEntity(Guid id)
        {
            var patientEntity = await _context.Patients.FindAsync(id);

            if (patientEntity == null)
            {
                return NotFound();
            }

            return patientEntity;
        }

        // PUT: api/PatientEntities/5
        [HttpPatch("{id}")]
        public async Task<IActionResult> PutPatientEntity(Guid id, PatientEntity patientEntity)
        {
            try
            {
                var data = await _context.Patients.FindAsync(id);
                data.PatientName = patientEntity.PatientName;
                data.PatientAge = patientEntity.PatientAge;
                data.PatientGender = patientEntity.PatientGender;
                data.PatientAddress = patientEntity.PatientAddress;
                data.PatientPhoneNumber = patientEntity.PatientPhoneNumber;
                data.PatientEmail = patientEntity.PatientEmail;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientEntityExists(id))
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

        // POST: api/PatientEntities
        [HttpPost]
        public async Task<ActionResult<PatientEntity>> PostPatientEntity(PatientEntity patientEntity)
        {
            _context.Patients.Add(patientEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPatientEntity", new { id = patientEntity.PatientId }, patientEntity);
        }

        // DELETE: api/PatientEntities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatientEntity(Guid id)
        {
            var patientEntity = await _context.Patients.FindAsync(id);
            if (patientEntity == null)
            {
                return NotFound();
            }

            _context.Patients.Remove(patientEntity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PatientEntityExists(Guid id)
        {
            return _context.Patients.Any(e => e.PatientId == id);
        }
    }
}
