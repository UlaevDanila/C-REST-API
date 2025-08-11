using ErrorOr;
using MediatR;
using OrderProductService.Application.Responses.Products;

namespace OrderProductService.Application.Queries.Product.GetProductById;

public record GetProductByIdQuery(Guid Id) 
    : IRequest<ErrorOr<ProductResponseDto>>;