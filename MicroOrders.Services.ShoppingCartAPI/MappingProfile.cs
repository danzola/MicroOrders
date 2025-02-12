using AutoMapper;
using MicroOrders.Services.ShoppingCartAPI.Models;
using MicroOrders.Services.ShoppingCartAPI.Models.Dto;

namespace MicroOrders.Services.ShoppingCartAPI
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            CreateMap<CartHeaderDto, CartHeader>().ReverseMap();
            CreateMap<CartDetailsDto, CartDetails>().ReverseMap();
        }
    }
}
