using ErrorOr;
using MediatR;
using OrderProductService.Application.Responses.Categories;
    
namespace OrderProductService.Application.Commands.Category.CreateCategory;

public record CreateCategoryCommand(string Name, string Description) : IRequest<ErrorOr<CategoryResponseDto>>;