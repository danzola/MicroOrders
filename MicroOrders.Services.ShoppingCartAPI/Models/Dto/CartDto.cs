namespace MicroOrders.Services.ShoppingCartAPI.Models.Dto
{
    public class CartDto
    {
        public CartHeaderDto CartHeader { get; set; } = default!;
        public IEnumerable<CartDetailsDto>? CartDetails { get; set; }
    }
}
