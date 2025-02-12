using MicroOrders.Services.ShoppingCartAPI.Models.Dto;
using MicroOrders.Services.ShoppingCartAPI.Service.IService;
using Newtonsoft.Json;

namespace MicroOrders.Services.ShoppingCartAPI.Service
{
    public class ProductService(IHttpClientFactory clientFactory) : IProductService
    {
        private readonly IHttpClientFactory _httpClientFactory = clientFactory;

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            var client = _httpClientFactory.CreateClient("Product");
            var response = await client.GetAsync($"/api/product");
            var apiContet = await response.Content.ReadAsStringAsync();
            var resp = JsonConvert.DeserializeObject<ResponseDto>(apiContet);
            if (resp != null && resp.IsSuccess)
            {
                return JsonConvert.DeserializeObject<IEnumerable<ProductDto>>(Convert.ToString(resp.Result));
            }
            return [];
        }
    }
}
