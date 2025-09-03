using OrderProductService.Application.Persistence;
using OrderProductService.Application.Responses.Orders;
using OrderProductService.Application.Responses.Products;

namespace OrderProductService.Infrastructure.OrdersPersistence;

public class OrderRepository : IOrderRepository
{
    public Task<IEnumerable<OrderResponseDto>> GetAllAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<OrderResponseDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<OrderResponseDto>> GetByStatusAsync(string status, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(OrderResponseDto orderItem, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task AddProductAsync(ProductResponseDto product, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task DeleteOrderAsync(OrderResponseDto order, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task DeleteProductAsync(ProductResponseDto product, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}