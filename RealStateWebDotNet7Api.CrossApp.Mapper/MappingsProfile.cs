
using AutoMapper;
using RealStateWebDotNet7Api.Domain.Entity;
using RealStateWebDotNet7Api.App.DTO;
namespace RealStateWebDotNet7Api.CrossApp.Mapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile() {
            CreateMap<Residents, ResidentsDTO>().ReverseMap(); 
            CreateMap<Users,UsersDto>().ReverseMap();
        }
    }
}