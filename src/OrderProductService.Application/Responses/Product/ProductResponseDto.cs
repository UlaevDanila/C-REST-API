namespace OrderProductService.Application.Responses.Product;

public record ProductResponseDto(
    string Name,
    string Description,
    decimal Price);