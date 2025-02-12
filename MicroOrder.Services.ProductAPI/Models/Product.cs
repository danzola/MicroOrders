using System.ComponentModel.DataAnnotations;

namespace MicroOrder.Services.ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; } = default!;
        [Range(1, 1000)]
        public double Price { get; set; }
        public string Description { get; set; } = default!;
        public string CategoryName { get; set; } = default!;
        public string? ImageUrl { get; set; }
    }
}
