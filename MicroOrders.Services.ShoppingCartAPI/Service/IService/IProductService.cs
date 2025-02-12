using MicroOrders.Services.ShoppingCartAPI.Models.Dto;

namespace MicroOrders.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
