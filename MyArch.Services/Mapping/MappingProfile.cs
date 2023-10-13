using AutoMapper;
using MyArch.BusinessLogic.Dtos;
using MyArch.Core.Entities;

namespace MyArch.BusinessLogic.Mapping
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
