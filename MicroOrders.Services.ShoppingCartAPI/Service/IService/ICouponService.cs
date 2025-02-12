using MicroOrders.Services.ShoppingCartAPI.Models.Dto;

namespace MicroOrders.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
