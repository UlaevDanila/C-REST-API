using ErrorOr;
using MediatR;
using OrderProductService.Application.Responses.Order;
using OrderProductService.Application.Responses.Product;

namespace OrderProductService.Application.Queries.Product.GetProductsByCategory;

public record GetProductsByCategoryQuery(string Category) : IRequest<ErrorOr<List<ProductResponseDto>>>;