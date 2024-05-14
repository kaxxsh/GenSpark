using AutoMapper;
using DoctorManagement.Models.Domain;
using DoctorManagement.Models.Dto;
using DoctorManagement.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoctorManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IMapper _mapper;

        public DoctorController(IDoctorRepository doctorRepository, IMapper mapper)
        {
            _doctorRepository = doctorRepository ?? throw new ArgumentNullException(nameof(doctorRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> GetDoctors()
        {
            var doctors = await _doctorRepository.GetAllAsync();
            var doctorDtos = _mapper.Map<List<GetDoctorDto>>(doctors);
            return Ok(doctorDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDoctor(Guid id)
        {
            var doctor = await _doctorRepository.GetByIdAsync(id);
            if (doctor == null)
            {
                return NotFound();
            }
            var doctorDto = _mapper.Map<GetDoctorDto>(doctor);
            return Ok(doctorDto);
        }

        [HttpPost]
        public async Task<IActionResult> AddDoctor(CreateDoctorDto createDoctorDto)
        {
            var doctor = _mapper.Map<Doctor>(createDoctorDto);
            await _doctorRepository.CreateAsync(doctor);
            var doctorDto = _mapper.Map<GetDoctorDto>(doctor);
            return CreatedAtAction(nameof(GetDoctor), new { id = doctorDto.Id }, doctorDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDoctor(Guid id, UpdateDoctorDto updateDoctorDto)
        {
            var doctor = await _doctorRepository.GetByIdAsync(id);
            if (doctor == null)
            {
                return NotFound();
            }
            _mapper.Map(updateDoctorDto, doctor);
            await _doctorRepository.UpdateAsync(doctor);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctor(Guid id)
        {
            var doctor = await _doctorRepository.GetByIdAsync(id);
            if (doctor == null)
            {
                return NotFound();
            }
            await _doctorRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
