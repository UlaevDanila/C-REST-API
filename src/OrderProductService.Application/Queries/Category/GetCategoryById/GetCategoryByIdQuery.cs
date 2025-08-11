using ErrorOr;
using MediatR;
using OrderProductService.Application.Responses.Category;

namespace OrderProductService.Application.Queries.Category.GetCategoryById;

public record GetCategoryByIdQuery(Guid Id) : IRequest<ErrorOr<CategoryResponseDto>>;