using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MicroOrders.Services.ShoppingCartAPI.Models.Dto;

namespace MicroOrders.Services.ShoppingCartAPI.Models
{
    public class CartDetails
    {
        [Key]
        public int CartDetailsId { get; set; }
        public int CartHeaderId { get; set; }
        [ForeignKey("CartHeaderId")]
        public CartHeader CartHeader { get; set; } = default!;
        public int ProductId { get; set; }
        [NotMapped]
        public ProductDto Product { get; set; } = default!;
        public int Count { get; set; }
    }
}
