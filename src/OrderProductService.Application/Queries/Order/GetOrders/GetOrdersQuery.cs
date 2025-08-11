using ErrorOr;
using MediatR;
using OrderProductService.Application.Responses.Order;
using OrderProductService.Domain.Entities.Orders;

namespace OrderProductService.Application.Queries.Order.GetOrders;

public record GetOrdersQuery : IRequest<ErrorOr<List<OrderResponseDto>>>;