using OrderProductService.Application.Persistence;
using OrderProductService.Application.Responses.Products;
using OrderProductService.Domain.Entities.Products;

namespace OrderProductService.Infrastructure.ProductsPersistence;

public class ProductRepository : IProductRepository
{
    public Task<IEnumerable<ProductResponseDto>> GetAllAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<ProductResponseDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductResponseDto>> GetByCategory(string category, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task CreateAsync(ProductResponseDto product, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(ProductResponseDto product, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Product product, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}