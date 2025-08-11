using OrderProductService.Application.Responses.Orders;
using OrderProductService.Application.Responses.Products;
using OrderProductService.Domain.Entities.Orders;
using OrderProductService.Domain.Entities.Products;

namespace OrderProductService.Application.Persistence;

public interface IOrderRepository
{
    public Task<IEnumerable<OrderResponseDto>> GetAllAsync(CancellationToken cancellationToken);

    public Task<OrderResponseDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    public Task<IEnumerable<OrderResponseDto>> GetByStatusAsync(string status, CancellationToken cancellationToken);

    public Task UpdateAsync(OrderResponseDto orderItem, CancellationToken cancellationToken);

    public Task AddProductAsync(ProductResponseDto product, CancellationToken cancellationToken);

    public Task DeleteOrderAsync(OrderResponseDto order, CancellationToken cancellationToken);

    public Task DeleteProductAsync(ProductResponseDto product, CancellationToken cancellationToken);
}