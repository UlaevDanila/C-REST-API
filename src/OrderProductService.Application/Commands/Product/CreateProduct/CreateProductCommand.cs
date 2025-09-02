using ErrorOr;
using MediatR;
using OrderProductService.Application.Responses.Products;

namespace OrderProductService.Application.Commands.Product.CreateProduct;

public record CreateProductCommand(string Name, string Description, decimal Price) : IRequest<ErrorOr<Domain.Entities.Products.Product>>;