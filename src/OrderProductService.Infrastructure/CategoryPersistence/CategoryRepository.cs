using OrderProductService.Application.Persistence;
using OrderProductService.Application.Responses.Categories;
using OrderProductService.Domain.Entities.Categories;

namespace OrderProductService.Infrastructure.CategoryPersistence;

public class CategoryRepository : ICategoryRepository
{
    public Task<IEnumerable<CategoryResponseDto>> GetAllAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<CategoryResponseDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task CreateAsync(Category category, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Category category, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(CategoryResponseDto category, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}