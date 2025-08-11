using ErrorOr;
using MediatR;
using OrderProductService.Application.Persistence;
using OrderProductService.Application.Responses.Categories;

namespace OrderProductService.Application.Commands.Category.DeleteCategory;

public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, ErrorOr<CategoryResponseDto>>
{
    private readonly ICategoryRepository _categoryRepository;

    private readonly IProductRepository _productRepository;

    public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository, IProductRepository productRepository)
    {
        _categoryRepository = categoryRepository;
        _productRepository = productRepository;
    }

    public async Task<ErrorOr<CategoryResponseDto>> Handle(DeleteCategoryCommand command, CancellationToken cancellationToken)
    {
        var category = await _categoryRepository.GetByIdAsync(command.Id, cancellationToken);

        var categoryProducts = await _productRepository.GetByCategory(category.Name, cancellationToken);

        if (categoryProducts == null)
        {
            await _categoryRepository.DeleteAsync(category, cancellationToken);

            await _categoryRepository.SaveChangesAsync(cancellationToken);
        }

        return category;
    }
}