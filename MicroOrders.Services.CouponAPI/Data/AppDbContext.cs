using MicroOrders.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroOrders.Services.CouponAPI.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Coupon> Coupons { get; set; }        
    }
}
