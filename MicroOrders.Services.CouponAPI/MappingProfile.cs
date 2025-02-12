using AutoMapper;
using MicroOrders.Services.CouponAPI.Models;
using MicroOrders.Services.CouponAPI.Models.Dto;

namespace MicroOrders.Services.CouponAPI
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CouponDto, Coupon>().ReverseMap();
        }
    }
}
