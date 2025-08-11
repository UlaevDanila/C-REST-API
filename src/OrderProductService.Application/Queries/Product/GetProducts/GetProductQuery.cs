using ErrorOr;
using MediatR;
using OrderProductService.Application.Responses.Product;

namespace OrderProductService.Application.Queries.Product.GetProducts;

public record GetProductQuery : IRequest<ErrorOr<List<ProductResponseDto>>>;