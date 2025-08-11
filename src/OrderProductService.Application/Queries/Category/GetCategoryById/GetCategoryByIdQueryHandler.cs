using ErrorOr;
using MediatR;
using OrderProductService.Application.Persistence;
using OrderProductService.Application.Responses.Category;

namespace OrderProductService.Application.Queries.Category.GetCategoryById;

public class GetCategoryByIdQueryHandler 
    : IRequestHandler<GetCategoryByIdQuery, ErrorOr<CategoryResponseDto>>
{
    private readonly ICategoryRepository _categoryRepository;

    public GetCategoryByIdQueryHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<ErrorOr<CategoryResponseDto>> Handle(GetCategoryByIdQuery query,
        CancellationToken cancellationToken)
    {
        var category = await _categoryRepository.GetByIdAsync(query.Id, cancellationToken);

        return category;
    }
}