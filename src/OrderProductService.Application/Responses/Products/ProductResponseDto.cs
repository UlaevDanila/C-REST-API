namespace OrderProductService.Application.Responses.Products;

public record ProductResponseDto(
    string Name,
    string Description,
    decimal Price);