using ErrorOr;
using MediatR;
using OrderProductService.Application.Persistence;
using OrderProductService.Application.Responses.Products;

namespace OrderProductService.Application.Queries.Product.GetProducts;

public class GetProductQueryHandler 
    : IRequestHandler<GetProductQuery, ErrorOr<List<ProductResponseDto>>>
{
    private readonly IProductRepository _productRepository;

    public GetProductQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<ErrorOr<List<ProductResponseDto>>> Handle(GetProductQuery query, CancellationToken cancellationToken)
    {
        var products = await _productRepository.GetAllAsync(cancellationToken);

        return products.ToList();
    }
}