using AutoMapper;
using MicroOrder.Services.ProductAPI.Models;
using MicroOrder.Services.ProductAPI.Models.Dto;

namespace MicroOrder.Services.ProductAPI
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
        }
    }
}
