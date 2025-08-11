using ErrorOr;
using MediatR;
using OrderProductService.Application.Persistence;
using OrderProductService.Application.Responses.Products;

namespace OrderProductService.Application.Queries.Product.GetProductsByCategory;

public class GetProductsByCategoryQueryHandler : IRequestHandler<GetProductsByCategoryQuery, ErrorOr<List<ProductResponseDto>>>
{
    private readonly IProductRepository _productRepository;

    public GetProductsByCategoryQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<ErrorOr<List<ProductResponseDto>>> Handle(GetProductsByCategoryQuery query,
        CancellationToken cancellationToken)
    {
        var products = await _productRepository.GetByCategory(query.Category, cancellationToken);

        return products.ToList();
    }
}