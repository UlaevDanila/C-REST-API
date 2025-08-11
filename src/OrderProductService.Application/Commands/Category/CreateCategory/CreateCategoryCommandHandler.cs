using ErrorOr;
using MediatR;
using OrderProductService.Application.Persistence;
using OrderProductService.Application.Responses.Categories;

namespace OrderProductService.Application.Commands.Category.CreateCategory;

public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, ErrorOr<CategoryResponseDto>>
{
    private readonly ICategoryRepository _categoryRepository;

    public CreateCategoryCommandHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<ErrorOr<CategoryResponseDto>> Handle(CreateCategoryCommand command,
        CancellationToken cancellationToken)
    {
        var category = new Category(command.Name, command.Description);

        await _categoryRepository.CreateAsync(category, cancellationToken);

        await _categoryRepository.SaveChangesAsync(cancellationToken);

        return category;
    }
}