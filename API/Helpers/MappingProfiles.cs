
using API.Dtos;
using AutoMapper;
using CORE.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                    .ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
                    .ForMember(d => d.ProductType, o => o.MapFrom(s => s.ProductType.Name))
                    .ForMember(D => D.PictureUrl, O => O.MapFrom<ProductUrlResolver>());
        }
    }
}