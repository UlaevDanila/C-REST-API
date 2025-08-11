using ErrorOr;
using MediatR;
using OrderProductService.Application.Responses.Orders;
using OrderProductService.Application.Responses.Products;

namespace OrderProductService.Application.Queries.Product.GetProductsByCategory;

public record GetProductsByCategoryQuery(string Category) : IRequest<ErrorOr<List<ProductResponseDto>>>;