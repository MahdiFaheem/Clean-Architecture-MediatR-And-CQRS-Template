using Application.Common.DTOs.EntityDTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Common.MappingConfigurations.DTOMappings
{
    class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<PersonDTO, Person>();
            CreateMap<Person, PersonDTO>();
        }
    }
}
