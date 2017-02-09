using AutoMapper;
using Rently.Dtos;
using Rently.Models;

namespace Rently.App_Start
{
    public class MappingProfile : Profile
    {
        //we create a mapping profile which show how objects of diffent types can be  mapped to eachother
        //constructor
        public MappingProfile()
        {
            // Domain to Dto    Source, Target 
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();


            // Dto to Domain  
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}