using ErrorOr;
using MediatR;
using OrderProductService.Application.Commands.Category.CreateCategory;
using OrderProductService.Application.Persistence;
using OrderProductService.Application.Responses.Products;

namespace OrderProductService.Application.Commands.Product.CreateProduct;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ErrorOr<Domain.Entities.Products.Product>>
{
    private readonly IProductRepository _productRepository;

    public CreateProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<ErrorOr<Domain.Entities.Products.Product>> Handle(CreateProductCommand command,
        CancellationToken cancellationToken)
    {
        var product = new Domain.Entities.Products.Product(command.Name, command.Description, command.Price);

        await _productRepository.DeleteAsync(product, cancellationToken);

        await _productRepository.SaveChangesAsync(cancellationToken);

        return product;
    }
}