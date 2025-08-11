using OrderProductService.Application.Responses.Product;

namespace OrderProductService.Application.Persistence;

public interface IProductRepository
{
    public Task<IEnumerable<ProductResponseDto>> GetAllAsync(CancellationToken cancellationToken);

    public Task<ProductResponseDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    public Task<IEnumerable<ProductResponseDto>> GetByCategory(string category, CancellationToken cancellationToken);

    public Task CreateAsync(ProductResponseDto product, CancellationToken cancellationToken);

    public Task UpdateAsync(ProductResponseDto product, CancellationToken cancellationToken);

    public Task DeleteAsync(ProductResponseDto product, CancellationToken cancellationToken);

    public Task SaveChangesAsync(CancellationToken cancellationToken);
}