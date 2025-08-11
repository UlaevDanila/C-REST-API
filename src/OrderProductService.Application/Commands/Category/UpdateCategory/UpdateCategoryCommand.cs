using ErrorOr;
using MediatR;
using OrderProductService.Application.Responses.Categories;

namespace OrderProductService.Application.Commands.Category.UpdateCategory;

public record UpdateCategoryCommand(string Name, string Description) : IRequest<ErrorOr<CategoryResponseDto>>;