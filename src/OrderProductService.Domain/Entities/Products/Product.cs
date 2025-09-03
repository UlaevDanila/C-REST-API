using OrderProductService.Domain.Common;

namespace OrderProductService.Domain.Entities.Products;

public class Product : Entity<Guid>
{
    public string Name { get; init; } = null!;

    public string Description { get; init; } = null!;
    
    public decimal Price { get; init; }
    
    public DateTime CreatedAt { get; init; } = DateTime.Now;

    public Product(string name, string description, decimal price)
    {
        Name = name;
        Description = description;
        Price = price;
    }
    
    #pragma warning disable CS8618
    private Product() {}
    #pragma warning restore CS8618
}