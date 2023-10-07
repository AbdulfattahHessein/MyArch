using AutoMapper;
using MyArch.Core.Entities;
using MyArch.Services.Dtos;

namespace MyArch.Services.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ReverseMap();


        }
    }
}
