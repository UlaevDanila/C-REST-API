using OrderProductService.Domain.Entities.Orders;

namespace OrderProductService.Application.Responses.Orders;

public record OrderResponseDto(
    OrderItem Order);