using OrderProductService.Application.Responses.Categories;
using OrderProductService.Domain.Entities.Categories;


namespace OrderProductService.Application.Persistence;

public interface ICategoryRepository
{
    public Task<IEnumerable<CategoryResponseDto>> GetAllAsync(CancellationToken cancellationToken);

    public Task<CategoryResponseDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    public Task CreateAsync(Category category, CancellationToken cancellationToken);

    public Task UpdateAsync(Category category, CancellationToken cancellationToken);

    public Task DeleteAsync(CategoryResponseDto category, CancellationToken cancellationToken);

    public Task SaveChangesAsync(CancellationToken cancellationToken);
}