using ErrorOr;
using MediatR;
using OrderProductService.Application.Persistence;
using OrderProductService.Application.Responses.Product;

namespace OrderProductService.Application.Queries.Product.GetProductById;

public class GetProductByIdQueryHandler
    : IRequestHandler<GetProductByIdQuery, ErrorOr<ProductResponseDto>>
{
    private readonly IProductRepository _productRepository;

    public GetProductByIdQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<ErrorOr<ProductResponseDto>> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetByIdAsync(query.Id, cancellationToken);
        return product!;
    }
}