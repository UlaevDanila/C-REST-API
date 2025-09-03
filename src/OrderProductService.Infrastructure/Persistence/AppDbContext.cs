using Microsoft.EntityFrameworkCore;
using OrderProductService.Domain.Entities.Categories;
using OrderProductService.Domain.Entities.Orders;
using OrderProductService.Domain.Entities.Products;

namespace OrderProductService.Infrastructure.Persistence;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Category> Categories { get; set;}
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSnakeCaseNamingConvention();
        
        base.OnConfiguring(optionsBuilder);
    }
}