using OrderProductService.Domain.Common;

namespace OrderProductService.Domain.Entities.Orders;

public class Order : Entity<Guid>
{
    public string CustomerName { get; init; } = null!;

    public string Address { get; init; } = null!;

    public DateTime OrderDate { get; init; } = DateTime.Now;

    public string Status { get; init; } = null!;

    public Order(string customerName, string address)
    {
        CustomerName = customerName;
        Address = address;
        Status = "new";
    }
}