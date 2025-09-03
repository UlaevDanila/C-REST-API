using ErrorOr;
using MediatR;
using OrderProductService.Application.Responses.Categories;

namespace OrderProductService.Application.Commands.Categories.UpdateCategory;

public record UpdateCategoryCommand(
    string Name, 
    string Description) : IRequest<ErrorOr<CategoryResponseDto>>;