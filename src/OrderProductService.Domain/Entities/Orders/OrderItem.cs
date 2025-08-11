using OrderProductService.Domain.Common;
using OrderProductService.Domain.Entities.Products;

namespace OrderProductService.Domain.Entities.Orders;

public class OrderItem : Entity
{
    public Order Order { get; init; } = null!;

    public IReadOnlyCollection<Product> Products { get; init; } = new List<Product>();

    public OrderItem(Order order, IReadOnlyCollection<Product> products)
    {
        Order = order;
        Products = products;
    }
    
    #pragma warning disable CS8618
    private OrderItem() {}
    #pragma warning disable CS8618
}