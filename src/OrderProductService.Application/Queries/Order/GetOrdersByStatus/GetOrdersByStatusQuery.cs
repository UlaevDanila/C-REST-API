using ErrorOr;
using MediatR;
using OrderProductService.Application.Responses.Orders;

namespace OrderProductService.Application.Queries.Order.GetOrdersByStatus;

public record GetOrdersByStatusQuery(string Status) : IRequest<ErrorOr<List<OrderResponseDto>>>;