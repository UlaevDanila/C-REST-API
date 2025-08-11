using ErrorOr;
using MediatR;
using OrderProductService.Application.Responses.Order;

namespace OrderProductService.Application.Queries.Order.GetOrderById;

public record GetOrderByIdQuery(Guid Id) : IRequest<ErrorOr<OrderResponseDto>>;