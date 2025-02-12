using MicroOrder.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroOrder.Services.ProductAPI.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }        
    }
}
