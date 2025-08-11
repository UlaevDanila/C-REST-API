using ErrorOr;
using MediatR;
using OrderProductService.Application.Persistence;
using OrderProductService.Application.Responses.Category;

namespace OrderProductService.Application.Queries.Category.GetCategories;

public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, ErrorOr<List<CategoryResponseDto>>>
{
    private readonly ICategoryRepository _categoryRepository;

    public GetCategoriesQueryHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<ErrorOr<List<CategoryResponseDto>>> Handle(GetCategoriesQuery query, CancellationToken cancellationToken)
    {
        var categories = await _categoryRepository.GetAllAsync(cancellationToken);

        return categories.ToList();
    }
}