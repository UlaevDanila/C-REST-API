using OrderProductService.Domain.Common;
using OrderProductService.Domain.Entities.Products;

namespace OrderProductService.Domain.Entities.Categories;

public class Category : Entity<Guid>
{
    public string Name { get; init; } = null!;

    public string Description { get; init; } = null!;

    public ICollection<Product> Products { get; } = new List<Product>();

    public Category(string name, string description)
    {
        Name = name;
        Description = description;
    }
    
    #pragma warning disable CS8618 
    private Category() {}
    #pragma warning disable CS8618
}