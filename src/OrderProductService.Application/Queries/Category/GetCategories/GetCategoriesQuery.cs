using ErrorOr;
using MediatR;
using OrderProductService.Application.Responses.Categories;

namespace OrderProductService.Application.Queries.Category.GetCategories;

public record GetCategoriesQuery : IRequest<ErrorOr<List<CategoryResponseDto>>>;