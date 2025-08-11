using OrderProductService.Domain.Entities.Orders;

namespace OrderProductService.Application.Responses.Order;

public record OrderResponseDto(
    OrderItem Order);