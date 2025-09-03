using ErrorOr;
using MediatR;
using OrderProductService.Application.Persistence;
using OrderProductService.Application.Responses.Categories;
using OrderProductService.Domain.Entities.Categories;

namespace OrderProductService.Application.Commands.Categories.UpdateCategory;

public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, ErrorOr<CategoryResponseDto>>
{
    private readonly ICategoryRepository _categoryRepository;

    public UpdateCategoryCommandHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<ErrorOr<CategoryResponseDto>> Handle(
        UpdateCategoryCommand command,
        CancellationToken cancellationToken)
    {
        var category = new Category(command.Name, command.Description);
        
        await _categoryRepository.UpdateAsync(category, cancellationToken);
        await _categoryRepository.SaveChangesAsync(cancellationToken);

        return new CategoryResponseDto(category.Name, category.Description);
    }
}