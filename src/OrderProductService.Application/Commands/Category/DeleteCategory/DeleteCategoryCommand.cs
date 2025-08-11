using ErrorOr;
using MediatR;
using OrderProductService.Application.Responses.Categories;

namespace OrderProductService.Application.Commands.Category.DeleteCategory;

public record DeleteCategoryCommand(Guid Id) : IRequest<ErrorOr<CategoryResponseDto>>;