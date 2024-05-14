using AutoMapper;
using DoctorManagement.Models.Domain;
using DoctorManagement.Models.Dto;

namespace DoctorManagement.Mapping
{
    public class autoMapping : Profile
    {
        public autoMapping()
        {
            CreateMap<Doctor, GetDoctorDto>().ReverseMap();
            CreateMap<CreateDoctorDto, Doctor>().ReverseMap();
            CreateMap<UpdateDoctorDto, Doctor>().ReverseMap();
        }
    }
}
